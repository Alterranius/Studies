using GraphMentor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphMentor.Static
{
    public abstract class Node
    {
        /// <summary>
        /// Параметрический размер, высота векторов
        /// </summary>
        public int Length { get; private set; }

        /// <summary>
        /// Положение в пространстве, статически влияющее на связи
        /// </summary>
        public vec Position { get; set; }

        /// <summary>
        /// Текущее значение
        /// </summary>
        public vec Value { get; set; }

        /// <summary>
        /// M-результат агрегации значения
        /// </summary>
        public vec M_Temp { get; set; }

        /// <summary>
        /// S-результат агрегации значения
        /// </summary>
        public vec S_Temp { get; set; }

        /// <summary>
        /// R-результат агрегации значения
        /// </summary>
        public vec R_Temp { get; set; }

        /// <summary>
        /// M-результат агрегации состояния
        /// </summary>
        public vec M_Refl { get; set; }

        /// <summary>
        /// S-результат агрегации состояния
        /// </summary>
        public vec S_Refl { get; set; }

        /// <summary>
        /// R-результат агрегации состояния
        /// </summary>
        public vec R_Refl { get; set; }

        /// <summary>
        /// Текущее состояние, типонезависимо
        /// </summary>
        public vec State { get; set; }

        /// <summary>
        /// Состояние отката от спайка
        /// </summary>
        public bool Spike { get; set; }

        /// <summary>
        /// Конфигурация сглаживания параметров при расчёте условия активации
        /// Чувствительность активационная.
        /// </summary>
        public vec SmoothActivation { get; set; }

        /// <summary>
        /// Конфигурация сглаживания параметров при торможении
        /// Чувствительность тормозная.
        /// </summary>
        public vec SmoothDelay { get; set; }

        /// <summary>
        /// Функция активации для расчёта порога активации
        /// </summary>
        public ActivationFunc ActivationFunc { get; set; }

        /// <summary>
        /// Функция торможения для расчёта порога торможения
        /// </summary>
        public DelayFunc DelayFunc { get; set; }

        /// <summary>
        /// Априорная чувствительность к слабому слою
        /// </summary>
        public Sensitivity M_Sensitivity { get; set; }

        /// <summary>
        /// Априорная чувствительность к сильному слою
        /// </summary>
        public Sensitivity S_Sensitivity { get; set; }

        /// <summary>
        /// Априорная чувствительность к свободному слою
        /// </summary>
        public Sensitivity R_Sensitivity { get; set; }

        /// <summary>
        /// Функция слабой агрегации
        /// </summary>
        public AggFunc M_AggFunc { get; set; }

        /// <summary>
        /// Функция сильной агрегации
        /// </summary>
        public AggFunc S_AggFunc { get; set; }

        /// <summary>
        /// Функция свободной агрегации
        /// </summary>
        public AggFunc R_AggFunc { get; set; }

        /// <summary>
        /// Функция агрегации при расчёте состояния
        /// </summary>
        public AggFunc StateAggFunc { get; set; }

        /// <summary>
        /// Веса слабых входов
        /// </summary>
        public matrix M_Weights { get; set; }

        /// <summary>
        /// Веса сильных входов
        /// </summary>
        public matrix S_Weights { get; set; }

        /// <summary>
        /// Веса свободных входов
        /// </summary>
        public matrix R_Weights { get; set; }

        /// <summary>
        /// Внутренние веса
        /// </summary>
        public matrix Weights { get; set; }

        /// <summary>
        /// Непрерывность
        /// </summary>
        public SigmaFunc SigmaFunc { get; set; }

        public RangeResolver RangeResolver { get; set; }

        public Mixer Mixer { get; set; }

        /// <summary>
        /// Слой, на котором находится узел
        /// </summary>
        public Slice Slice { get; set; }

        public HashSet<NodeTuple> M_Neighbours 
        {
            get 
            {
                return Slice.GetM_Neighbours(this);
            }
            private set {}
        }

        public HashSet<NodeTuple> S_Neighbours
        {
            get
            {
                return Slice.GetS_Neighbours(this);
            }
            private set {}
        }

        public HashSet<NodeTuple> R_Neighbours
        {
            get
            {
                return Slice.GetR_Neighbours(this);
            }
            private set {}
        }

        public Queue<NodeTuple> M_ToComplete = new Queue<NodeTuple>();
        public Queue<NodeTuple> S_ToComplete = new Queue<NodeTuple>();
        public Queue<NodeTuple> R_ToComplete = new Queue<NodeTuple>();

        public bool ToComplete 
        {
            get 
            {
                return (M_ToComplete.Count + S_ToComplete.Count + R_ToComplete.Count) > 0;
            }
            private set {}
        }

        protected Node(vec position, int length, vec smoothActivation, vec smoothDelay, ActivationFunc activationFunc, DelayFunc delayFunc, Sensitivity m_sensitivity, Sensitivity s_sensitivity, Sensitivity r_Sensitivity, AggFunc m_aggFunc, AggFunc s_aggFunc, AggFunc r_AggFunc, AggFunc stateAggFunc, matrix m_weights, matrix s_weights, matrix r_Weights, matrix weights, SigmaFunc sigmaFunc, RangeResolver rangeResolver, Slice slice)
        {
            Position = position;
            Length = length;
            Slice = slice;
            RangeResolver = rangeResolver;
            SmoothActivation = smoothActivation;
            SmoothDelay = smoothDelay;
            ActivationFunc = activationFunc;
            DelayFunc = delayFunc;
            M_Sensitivity = m_sensitivity;
            S_Sensitivity = s_sensitivity;
            R_Sensitivity = r_Sensitivity;
            M_AggFunc = m_aggFunc;
            S_AggFunc = s_aggFunc;
            R_AggFunc = r_AggFunc;
            StateAggFunc = stateAggFunc;
            M_Weights = m_weights;
            S_Weights = s_weights;
            R_Weights = r_Weights;
            Weights = weights;
            SigmaFunc = sigmaFunc;
            Value = new vec(vec.VEC0(Length));
            ConfigureState();
        }

        /// <summary>
        /// Инициализация состояния при создании узла
        /// </summary>
        protected abstract void ConfigureState();

        /// <summary>
        /// Процедура итерации узла
        /// </summary>
        public void Compute()
        {
            if (Spike)
            {
                Delay(); // Обработка длящегося спайка (откат перед возможностью нового спайка)
                return;
            }
            PreReflect(); // Подготовка состояния в зависимости от соседей (прямая зависимость от полного окружения, полный расчёт внешнего состояния)
            if (!ToComplete)
                return;
            Complete(); // Расчёт значения и коррекция состояния в зависимости от активных соседей (полный расчёт значения, кумулятивный расчёт состояния, важна дельта состояния)
            Aggregate(); // Агрегация и стабилизация значения узла (выработка итогового значения)
            Activation(); // Проверка активации узла (спайк)
            if (Spike)
                ActivationReflect(); // Коррекция состояния в зависимости от активации
            Train(); // Расчёт сдвига весов (в зависимости от состояния (сила сдвига) и дельты состояния (веса сдвига))
        }

        /// <summary>
        /// Процедура обучения
        /// </summary>
        protected void Train()
        {
            M_Train();
            S_Train();
            R_Train();
            Internal_Train();
        }

        /// <summary>
        /// Процедура стабилизации значения
        /// </summary>
        protected void Aggregate()
        {
            Mix();
            Normalize();
        }

        /// <summary>
        /// Процедура расчёта значения
        /// </summary>
        protected void Complete()
        {
            S_Complete();
            if (Spike)
                return;
            M_Complete();
            if (Spike)
                return;
            R_Complete();
        }
        protected void M_Complete()
        {
            List<vec> agregat = new List<vec>();
            foreach (NodeTuple tuple in M_ToComplete)
            {
                agregat.Add(
                    M_Sensitivity.Get(tuple.Root.Value).Scale(RangeResolver.Get(tuple.Range)));
                M_ToComplete.Dequeue();
            }
            M_Temp = M_AggFunc.Agg(M_Weights, agregat);
            M_Reflect();
        }
        protected void S_Complete()
        {
            List<vec> agregat = new List<vec>();
            foreach (NodeTuple tuple in S_Neighbours)
            {
                agregat.Add(
                    S_Sensitivity.Get(tuple.Root.Value));
                S_ToComplete.Dequeue();
            }
            S_Temp = S_AggFunc.Agg(S_Weights, agregat);
            S_Reflect();
        }
        protected void R_Complete()
        {
            List<vec> agregat = new List<vec>();
            foreach (NodeTuple tuple in R_Neighbours)
            {
                agregat.Add(
                    R_Sensitivity.Get(tuple.Root.Value).Scale(RangeResolver.Get(tuple.Range)));
                R_ToComplete.Dequeue();
            }
            R_Temp = R_AggFunc.Agg(R_Weights, agregat);
            R_Reflect();
        }

        protected void R_PreReflection()
        {
            List<vec> agregat = new List<vec>();
            foreach (NodeTuple tuple in R_Neighbours)
            {
                agregat.Add(
                    R_Sensitivity.Get(tuple.Root.State).Scale(RangeResolver.Get(tuple.Range)));
                Slice.ToComplete.Enqueue(tuple.Root);
                if (tuple.Root.Spike)
                    R_ToComplete.Enqueue(tuple);
            }
            R_Refl = StateAggFunc.Agg(R_Weights, agregat);
        }

        protected void M_PreReflection()
        {
            List<vec> agregat = new List<vec>();
            foreach (NodeTuple tuple in M_Neighbours)
            {
                agregat.Add(
                    M_Sensitivity.Get(tuple.Node.Value).Scale(RangeResolver.Get(tuple.Range)));
                Slice.ToComplete.Enqueue(tuple.Root);
                if (tuple.Root.Spike)
                    M_ToComplete.Enqueue(tuple);
            }
            M_Refl = StateAggFunc.Agg(M_Weights, agregat);
        }

        protected void S_PreReflection()
        {
            List<vec> agregat = new List<vec>();
            foreach (NodeTuple tuple in S_Neighbours)
            {
                agregat.Add(
                    S_Sensitivity.Get(tuple.Node.Value).Scale(RangeResolver.Get(tuple.Range)));
                Slice.ToComplete.Enqueue(tuple.Root);
                if (tuple.Root.Spike)
                    S_ToComplete.Enqueue(tuple);
            }
            S_Refl = StateAggFunc.Agg(S_Weights, agregat);
        }

        /// <summary>
        /// Процедура предварительного расчёта состояния
        /// </summary>
        protected void PreReflect()
        {
            S_PreReflection();
            M_PreReflection();
            R_PreReflection();
            List<vec> vecs = new List<vec>
            {
                S_Refl,
                M_Refl,
                R_Refl
            };
            State = StateAggFunc.Agg(Weights, vecs);
        }

        protected void Mix()
        {
            Value = Mixer.Mix(Weights, State, S_Temp, M_Temp, R_Temp);
        }
        protected void Normalize()
        {
            Value = SigmaFunc.Get(Value);
        }

        protected abstract void M_Train();
        protected abstract void S_Train();
        protected abstract void R_Train();
        protected abstract void Internal_Train();

        /// <summary>
        /// Процедура отката при спайке узла
        /// </summary>
        protected abstract void Delay();
        
        /// <summary>
        /// Процедура апостериорного расчёта R-состояния
        /// </summary>
        protected abstract void R_Reflect();

        /// <summary>
        /// Процедура апостериорного расчёта M-состояния
        /// </summary>
        protected abstract void M_Reflect();

        /// <summary>
        /// Процедура апостериорного расчёта S-состояния
        /// </summary>
        protected abstract void S_Reflect();

        /// <summary>
        /// Процедура коррекции состояния при спайке
        /// </summary>
        protected abstract void ActivationReflect();

        protected void Activation()
        {
            Spike = ActivationFunc.Activate(SmoothActivation, Value, State);
        }
    }
}
