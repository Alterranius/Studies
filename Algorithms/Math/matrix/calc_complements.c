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

int calc_complements(matrix *A, matrix **result)
{
    int res_value = INCORRECT_MATRIX;
    double det_sub = 0.0;
    matrix *tmp;

    if (A->columns > 0 && A->rows > 0 && A->matrix != NULL)
    {
        if (A->columns == A->rows)
        {

            res_value = OK;
            (*result) = create_matrix(A->rows, A->columns);
            if (!*result)
                return (CALC_ERROR);

            for (int i = 0; i < (*result)->rows; i++)
            {
                for (int j = 0; j < (*result)->columns; j++)
                {
                    tmp = minor_matrix(A, i, j);
                    determinant(tmp, &det_sub);

                    (*result)->matrix[i][j] = det_sub;
                    if (i + j % 2 == 1)
                    {
                        (*result)->matrix[i][j] *= (-1);
                    }
                    remove_matrix(tmp);
                }
            }
        }
        else
        {
            res_value = CALC_ERROR;
        }
    }
    return (res_value);
}