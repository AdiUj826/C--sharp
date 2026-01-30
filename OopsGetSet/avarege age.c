#include <stdio.h>

int main() {
    int age[4];

    int i, sum = 0;
   float average;




    for(i = 0; i < 4; i++) {
printf("Enter age of person %d: ", i + 1);
        scanf("%d", &age[i]);
       sum += age[i];
   }

   average = sum / 4.0;

    printf("Average age = %.2f\n", average);

    return 0;
}

