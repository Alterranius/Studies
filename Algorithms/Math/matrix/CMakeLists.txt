cmake_minimum_required(VERSION 3.26)
project(matrix C)

set(CMAKE_C_STANDARD 99)

add_library(matrix SHARED
        remove_matrix.c
        scale_matrix.c
        matrix_setValue.c
        sub_matrix.c
        sum_matrix.c
        transpose_matrix.c
        print_matrix.c
        mult_matrix.c
        inverse_matrix.c
        fill_matrix.c
        equals_matrix.c
        create_matrix.c
        determinant.c
        calc_complements.c)
