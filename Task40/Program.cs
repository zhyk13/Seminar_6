﻿// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше
//суммы двух других сторон.


int storona (string msg)
{

System.Console.WriteLine(msg);
return Convert.ToInt32(System.Console.ReadLine());
}

int a=storona("Введите натуральное число: ");
int b=storona("Введите натуральное число: ");
int c=storona("Введите натуральное число: ");

if ((a<b+c)&&(b<a+c)&&(c<b+a))
{System.Console.WriteLine("Из отрезков заданной длины можно сделать треугольник");}
else 
{System.Console.WriteLine("Треугольник не получится");}

Console.WriteLine("Hello, World!");
