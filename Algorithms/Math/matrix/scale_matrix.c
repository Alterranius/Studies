#include "l_algebra.h"

static int is_correct(matrix *A)
{
    return (A && A->rows > 0 && A->columns > 0);
}

matrix *scale_matrix(matrix *A, double number)
{
    matrix *result;

    if (!is_correct(A))
        return (NULL);

    result = create_matrix(A->rows, A->columns);
    if (result == NULL)
        return (NULL);

    for (int i = 0; i < A->rows; i++)
    {
        for (int j = 0; j < A->columns; j++)
        {
            result->matrix[i][j] = A->matrix[i][j] * number;
        }
    }
    return (result);
}