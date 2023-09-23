#include "l_algebra.h"

int fill_matrix(matrix *A)
{
    if (A == NULL)
        return (0);

    for (int i = 0; i < A->rows; i++)
    {
        for (int j = 0; j < A->columns; j++)
        {
            scanf("%lf", &A->matrix[i][j]);
        }
    }
    return (1);
}