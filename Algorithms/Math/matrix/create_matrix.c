#include "l_algebra.h"

matrix *create_matrix(const int rows, const int columns)
{
    if (rows <= 0 || columns <= 0)
        return (NULL);
    matrix *result;
    result = malloc(sizeof(matrix));
    if (!result)
        return NULL;

    result->rows = rows;
    result->columns = columns;
    result->matrix = calloc(rows, sizeof(double *));
    if (!result->matrix)
        return (NULL);
    for (int i = 0; i < rows; i++)
    {
        result->matrix[i] = calloc(columns, sizeof(double));
        if (!result->matrix[i])
        {
            for (int j = 0; j < i; j++)
                free(result->matrix[j]);
            free(result->matrix);
            free(result);
            return (NULL);
        }
    }
    return (result);
}