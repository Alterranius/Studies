#include "l_algebra.h"

static int is_correct(matrix *A)
{
    return (A && A->rows > 0 && A->columns > 0);
}

matrix *mult_matrix(matrix *A, matrix *B)
{
    matrix *result;

    if (!is_correct(A) || !is_correct(B))
        return (NULL);

    if ((A->columns != B->rows) || (A->rows != B->columns))
        return (NULL);

    result = create_matrix(A->rows, B->columns);
    if (result == NULL)
        return (NULL);

    for (int i = 0; i < A->rows; i++)
    {
        for (int j = 0; j < B->columns; j++)
        {
            result->matrix[i][j] = 0;
            for (int k = 0; k < A->columns; k++)
            {
                result->matrix[i][j] += A->matrix[i][k] * B->matrix[k][j];
            }
        }
    }
    return (result);
}