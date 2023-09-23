#include "l_algebra.h"

matrix *transpose_matrix(matrix *A)
{
    matrix *result;

    result = create_matrix(A->columns, A->rows);
    if (result == NULL)
        return (NULL);

    for (int i = 0; i < A->rows; i++)
    {
        for (int j = 0; j < A->columns; j++)
        {
            result->matrix[j][i] = A->matrix[i][j];
        }
    }
    return (result);
}