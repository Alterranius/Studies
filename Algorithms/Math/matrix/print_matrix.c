#include "l_algebra.h"

void print_matrix(matrix *A)
{
    if (A == NULL)
        return;

    for (int i = 0; i < A->rows; i++)
    {
        for (int j = 0; j < A->columns; j++)
        {
            printf("%lf ", A->matrix[i][j]);
        }
        printf("\n");
    }
}