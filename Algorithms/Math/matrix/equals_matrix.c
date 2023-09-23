#include "l_algebra.h"

int equals_matrix(matrix *A, matrix *B)
{
    if (A->rows != B->rows || A->columns != B->columns)
        return (FAILURE);

    for (int i = 0; i < A->rows; i++)
    {
        for (int j = 0; j < A->columns; j++)
        {
            if (fabs(A->matrix[i][j] - B->matrix[i][j]) > EPSILON)
                return (FAILURE);
        }
    }
    return (SUCCESS);
}