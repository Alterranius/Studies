#include "l_algebra.h"

void remove_matrix(matrix *A)
{
    for (int i = 0; i < A->rows; i++)
    {
        free(A->matrix[i]);
    }
    
    free(A->matrix);
    A->rows = 0;
    A->columns = 0;
}