//Задача: Написать программу, которая из сформированного массива строк содержащих символы и числа 
//создать массив из строк, в который попадут только символы, не являющиеця цифрами.

Console.Clear();
char[] data = ("Ка6кой-то88 ран5домны!й те90кст").ToCharArray();
var result = string.Empty;
foreach(var item in data)
{
if(!char.IsDigit(item))
result+= item;
}