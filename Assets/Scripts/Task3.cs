using UnityEngine;
using System;

namespace HomeWork1
{
    public class Task3  
    {
        static void Main(string[] args)
        {
            String _quitProgram = "quitProgram";
            String startProgram = "Здравствуйте вас приветствует математическая программа";
            String writeNumber = "Пожалуйста введите число";
            String _firstnumber;
            Console.WriteLine((startProgram));
            Console.WriteLine(writeNumber);
            _firstnumber = Console.ReadLine();
            if (_firstnumber == _quitProgram)
            {
                return;
            }
            else
            {
                Fact(_firstnumber);
            }

            static void Fact(String _firstnumber)
            {
                int _intNumber;
                int _numberFactorial = 1;
                int _sumNumbers = 0;
                int _maxEvenNumber = 0;
                string textResultFactorial = "Факториал равен";
                string textSumNumbers = "Сумма от 1 до Number равна";
                string textMaxEvenNumber = "Максимальное четное число меньше Number равно"; 
                _intNumber = Int32.Parse(_firstnumber);

                for (int i = 1; i <= _intNumber; i++)
                {
                    _numberFactorial = _numberFactorial * i;
                    _sumNumbers = _sumNumbers + i;
                    if (i % 2 == 0)
                    {
                        _maxEvenNumber = i;
                    }
                }

                Console.WriteLine(textResultFactorial + _numberFactorial);
                Console.WriteLine(textSumNumbers + _sumNumbers);
                Console.WriteLine(textMaxEvenNumber + _maxEvenNumber);
            }
        }
    }
}