#include "l_algebra.h"

static int is_correct(matrix *A)
{
    return (A && A->rows > 0 && A->columns > 0);
}

matrix *sub_matrix(matrix *A, matrix *B)
{
    matrix *result;

    if (!is_correct(A) || !is_correct(B))
        return (NULL);

    if (A->rows != B->rows || A->columns != B->columns)
        return (NULL);

    result = create_matrix(A->rows, A->columns);
    if (result == NULL)
        return (NULL);

    for (int i = 0; i < A->rows; i++)
    {
        for (int j = 0; j < A->columns; j++)
        {
            result->matrix[i][j] = A->matrix[i][j] - B->matrix[i][j];
        }
    }
    return (result);
}