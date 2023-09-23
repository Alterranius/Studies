#include "l_algebra.h"

static matrix *minor_matrix(matrix *A, int rows, int columns)
{
    matrix *minor_matrix;

    minor_matrix = create_matrix(A->rows - 1, A->columns - 1);
    if (!minor_matrix)
        return (NULL);
    for (int i = 0, x = 0; i < A->rows; ++i)
    {
        if (rows != i)
        {
            for (int j = 0, y = 0; j < A->columns; ++j)
            {
                if (columns != j)
                {
                    minor_matrix->matrix[x][y] = A->matrix[i][j];
                    y++;
                }
            }
            x++;
        }
    }
    return (minor_matrix);
}

int determinant(matrix *A, double *result)
{
    matrix *minor;
    int return_value = INCORRECT_MATRIX;
    double tmp_determinant;
    double tmp_res;

    if (A->columns > 0 && A->rows > 0 && A->matrix != NULL)
    {
        if (A->columns == A->rows)
        {
            if (A->rows == 1)
            {
                return_value = OK;
                *result = A->matrix[0][0];
            }
            else if (A->rows > 1)
            {
                return_value = OK;
                *result = 0;
                for (int i = 0; i < A->columns; i++)
                {
                    minor = minor_matrix(A, i, 0);
                    determinant(minor, &tmp_determinant);
                    tmp_res = A->matrix[i][0] * tmp_determinant;

                    if ((2 + i) % 2 == 1)
                        tmp_res *= (-1);
                    *result += tmp_res;

                    remove_matrix(minor);
                }
            }
        }
        else
        {
            return_value = CALC_ERROR;
        }
    }
    return (return_value);
}