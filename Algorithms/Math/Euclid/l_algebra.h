#ifndef MATRIX_L_ALGEBRA_H
#define MATRIX_L_ALGEBRA_H

#include <stdlib.h>
#include <stdio.h>
#include <math.h>

#define SUCCESS 1
#define FAILURE 0

#define EPSILON 1e-07

enum
{
    OK = 0,
    INCORRECT_MATRIX = 1,
    CALC_ERROR = 2,
    MALLOC_FAILED = 3
};

typedef struct matrix_struct
{
    double **matrix;
    int rows;
    int columns;
} matrix;

matrix *create_matrix(const int rows, const int columns);
void remove_matrix(matrix *A);
void print_matrix(matrix *A);
int fill_matrix(matrix *A);
int equals_matrix(matrix *A, matrix *B);
matrix *sum_matrix(matrix *A, matrix *B);
matrix *sub_matrix(matrix *A, matrix *B);
matrix *scale_matrix(matrix *A, double number);
matrix *mult_matrix(matrix *A, matrix *B);
matrix *transpose_matrix(matrix *A);
int calc_complements(matrix *A, matrix **result);
int determinant(matrix *A, double *result);
int inverse_matrix(matrix *A, matrix **result);
int matrix_setValue(matrix *A, double value[A->rows][A->columns]);

#endif
