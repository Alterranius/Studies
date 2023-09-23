#include "l_algebra.h"

int inverse_matrix(matrix *A, matrix **result)
{
    matrix *algeb_dop;
    matrix *algeb_dopT;
    double determinantD;

    algeb_dop = NULL;
    calc_complements(A, &algeb_dop);
    determinant(A, &determinantD);
    algeb_dopT = transpose_matrix(algeb_dop);

    for (int i = 0; i < algeb_dopT->rows; i++)
    {
        for (int j = 0; j < algeb_dopT->columns; j++)
        {
            algeb_dopT->matrix[i][j] = algeb_dopT->matrix[i][j] / determinantD;
        }
    }
    *result = algeb_dopT;
    remove_matrix(algeb_dop);
    return (0);
}