#include <stdio.h>

int main() {
    int n = 7;
    for (int i = 1; i <= n; i++)
    {
        for (int j = n; j >= 0; j--)
        {
            if (j >= i)
            {
                printf(" ");
            }
            else
            {
                printf("%d ", i);
            }
        }
        printf("\n");
    }
    return 0;
}