#include <l_algebra.h>
#include <stdio.h>

int *extended_euclid_matrix(int a, int b)
{
    static int answer[3];
    int temp = 0;
    int counter = 0;
    matrix *A;
    matrix *tempA;

    A = create_matrix(2, 2);
    double A_value[2][2] = {{1, 0},
                            {0, 1}};

    if (a < b)
    {
        temp = a;
        a = b;
        b = temp;
        A_value[0][0] = 0;
        A_value[1][1] = 0;
        A_value[0][1] = -1;
        A_value[1][0] = -1;
    }

    tempA = create_matrix(2, 2);
    double tempA_value[2][2] = {{(int)a / b, 1},
                                {1, 0}};

    matrix_setValue(A, A_value);
    matrix_setValue(tempA, tempA_value);

    while (b != 0)
    {
        tempA->matrix[0][0] = (int)a / b;
        A = mult_matrix(tempA, A);

        temp = a;
        a = b;
        b = temp % a;

        counter++;
    }
    answer[0] = a;
    answer[1] = (int)A->matrix[1][1] * (!(counter & 1) ? 1 : (-1));
    answer[2] = (int)A->matrix[1][0] * ((counter & 1) ? 1 : (-1));
    print_matrix(A);
    return answer;
}

int main()
{
    int a, b;
    printf("Input a, b: ");
    scanf("%d %d", &a, &b);
    int *answer = extended_euclid_matrix(a, b);
    printf("extended_euclid: %d, %d, %d\n", answer[0], answer[1], answer[2]);
    return 0;
}