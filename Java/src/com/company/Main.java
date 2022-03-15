package com.company;
import java.util.Scanner;
public class Main {

    static float del(float a, float b)
    {
        if (b == 0) { throw null; }
        else return a / b;
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        float numb1, numb2;
        System.out.print("Enter digit 1\nEnter:");
        numb1 = scanner.nextInt();
        System.out.print("Enter digit 2\nEnter:");
        numb2 = scanner.nextInt();
        try
        {
            System.out.print("Answer: " + del(numb1, numb2));
        }
        catch (Throwable b)
        {
            System.out.print("Error: digit 2 can't be 0!\n");
        }
    }
}
