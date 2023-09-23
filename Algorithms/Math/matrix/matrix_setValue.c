#include "l_algebra.h"

int matrix_setValue(matrix *A, double value[A->rows][A->columns])
{
    for (int i = 0; i < A->rows; i++)
    {
        for (int j = 0; j < A->columns; j++)
        {
            A->matrix[i][j] = value[i][j];
        }
    }
    return 0;
}