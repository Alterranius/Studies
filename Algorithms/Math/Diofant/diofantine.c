// #define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>
#include <windows.h>

//расширенный евклид
int extended_euclid(int a, int b, int *x, int *y) {
    int k;
    int ost = 0;
    //int x, y;
    int A[2][2] = {{1, 0},
                   {0, 1}};

    int n1 = 1; //знак x в конце
    int n2 = 1; //знак y в конце

    if (a < 0) {
        a = -a;
        n1 = -1;
    }

    if (b < 0) {
        b = -b;
        n2 = -1;
    }

    while (b) {
        k = a / b;

        *x = A[0][0] - k * A[1][0];
        *y = A[0][1] - k * A[1][1];

        A[0][0] = A[1][0];
        A[0][1] = A[1][1];
        A[1][0] = *x;
        A[1][1] = *y;

        ost = a % b;
        a = b;
        b = ost;
    }
    *x = A[0][0] * n1;
    *y = A[0][1] * n2;

    return a;
}

//поиск обратного по модулю (a*x=1 (mod m))
int mul_inverse(int a, int m) {
    if (a > m) {
        a = a + m;
        m = a - m;
        a = a - m;
    }
    int x, y;
    int gcd = extended_euclid(a, m, &x, &y);
    int inverse = 0;
    if (gcd == 1)
        inverse = x;

    return inverse;
}

//линейные диофантовы мое решение
int linear_diophantine(const int *a, int *x, const int n, int b) {
    int *gcd;
    int **k;

    gcd = (int *) malloc(n * sizeof(int));
    k = (int **) (int *) malloc(n * sizeof(int));
    for (int i = 0; i < n; i++) {
        k[i] = (int *) malloc(2 * sizeof(int));
    }

    // gcd[0] = a0
    // gcd[1] = gcd(a0,a1)
    // gcd[2] = gcd[a0,a1,a2)...
    //
    // k - пары xA,xB для a*xA + b*xB = c, где a,b,c известны
    // k[0] = 1,0
    // k[1] = x0, x1 для a0x0+a1x1=gcd(a0,a1)
    // k[2] = xA, x2 для gcd(a0,a1)*xA + a2x2 = gcd(a0,a1,a2)
    // k[3] = xA, x3 для gcd(a0,a1,a2)*xA + a3x3 = gcd(a0,a1,a2,a3)

    gcd[0] = a[0];
    k[0][0] = 1;
    k[0][1] = 0;

    for (int i = 1; i <= n - 1; i++) {
        int x, y;
        int answer = extended_euclid(gcd[i - 1], a[i], &x, &y);

        gcd[i] = answer;
        k[i][0] = x;
        k[i][1] = y;
    }

    for (int i = n - 1; i > 0; i--) {
        double c = b / gcd[i];
        // Xn = k[i][1], Xa = k[i][0]
        // b = xA * c * gcd

        if (c - (int) c == 0) {
            x[i] = k[i][1] * (int) c;
            x[i - 1] = k[i][0] * (int) c; // создает n-1 перезаписей, но исключает if на каждой итерации
            // if (i==1) x[i-1] = xA; //не создает перезаписей, но вынуждает проверять крайний случай на каждой итерации
            b = k[i][0] * (int) c * gcd[i - 1];
        } else {
            printf("Very bad!\n");
            return 0;
        }
    }

    return 1;
}

//линейные диофантовы аккуратное решение
int lin_dif(int *a, int *x, int n, int b) {
    int gcd = a[n - 1];
    int xA = 1;
    x[n - 1] = 1;

    for (int i = n - 2; i >= 0; i--) {
        gcd = extended_euclid(a[i], gcd, &x[i], &xA);
        for (int j = i + 1; j < n; j++) {
            x[j] *= xA;
        }
    }
    printf("gcd = %d", gcd);
    if (b % gcd == 0) {
        b /= gcd;
        for (int i = 0; i < n; i++) {
            x[i] *= b;
            printf("x%d = %d\n", i, x[i]);
        }
    } else {
        printf("very bad");
        return 0;
    }
    return 1;
}


int main() {
    int choice = 0;
    int x1, x2, n, b;
    printf("0 - Extended Euclid\n1 - Inverse M\n2 - Linear Diophantine\nInput: ");
    scanf("%d", &choice);
    switch (choice) {
        case 0:
            printf("Extended Euclid. Input x, y: ");
            scanf("%d %d", &x1, &x2);

            if (x1 && x2) {
                int a, b;
                int answer = extended_euclid(x1, x2, &a, &b);
                printf("extended_euclid: gcd %d, x %d, y %d\n", answer, a, b);
            }
            break;

        case 1:
            printf("Inverse. Input a, m: ");
            scanf("%d %d", &x1, &x2);

            if (x1 && x2) {
                int answer = mul_inverse(x1, x2);
                printf("mul_inverse: %d\n", answer);
            }
            break;

        case 2:
            printf("Linear Diophantine. Input n, b: ");
            scanf("%d %d", &n, &b);

            int *X;
            int *A;

            X = (int *) malloc(n * sizeof(int));
            A = (int *) malloc(n * sizeof(int));

            for (int i = 0; i < n; i++) {
                printf("Input a%d ", i);
                scanf("%d", &A[i]);
                X[i] = 0;
            }

            int result = lin_dif(A, X, n, b);
            printf("result is %d\n", result);
            break;
    }
    return 0;
}