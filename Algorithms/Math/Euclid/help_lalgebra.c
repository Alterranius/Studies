#include <l_algebra.h>
#include <stdio.h>

int main()
{
    
    matrix *B;

    matrix *A; // Объявление
    A = create_matrix(2, 2); // Инициализация
    double A_value[2][2] = {{1, 2},
                            {3, 1}}; // Данные для заполнения
    matrix_setValue(A, A_value); // Заполнение
    print_matrix(A); // Красивый вывод
    fill_matrix(A);
    print_matrix(A);

    B = create_matrix(2, 2);
    print_matrix(B);
    fill_matrix(B);
    print_matrix(B);

    printf("equals_matrix\n");
    printf("%d\n", equals_matrix(A, B));

    printf("sum_matrix\n");
    print_matrix(sum_matrix(A, B));
    printf("\n");

    printf("sub_matrix\n");
    print_matrix(sub_matrix(A, B));
    printf("\n");

    printf("scale_matrix\n");
    print_matrix(scale_matrix(A, 7));
    printf("\n");

    printf("transpose_matrix\n");
    print_matrix(transpose_matrix(A));
    printf("\n");

    printf("determinant\n");
    double res = 5;
    print_matrix(A);
    determinant(A, &res);
    printf("%lf\n", res);

    matrix *res_minors;
    res_minors = NULL;
    printf("calc_complements\n");
    calc_complements(A, &res_minors);
    print_matrix(res_minors);
    printf("\n");

    matrix *res_minorss;
    printf("inverse_matrix\n");
    inverse_matrix(A, &res_minorss);
    print_matrix(res_minorss);
    printf("\n");

    return (0);
}