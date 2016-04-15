using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FANNCSharp;
using FANNCSharp.Float;
using System.IO;

namespace ScoringSystem.NeuralNetwork {
    class NeuralNetwork {

        public static void MainFunc() {
            ConsoleKeyInfo cki;

            do {
                Console.WriteLine("Выберите что делать:\n1 - Обучить\n2 - Тестить");
                int i = 0;

                i = int.Parse(Console.ReadLine());
                switch (i) {
                    case 1: {
                            learnNeuralNetwork();
                            break;
                        }
                    case 2: {
                            test();
                            break;
                        }
                }
                Console.WriteLine("Продолжить?\nEscape - нет");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);

        }
        /// <summary>
        /// Function which learn ,y neural netwark
        /// </summary>
        public static void learnNeuralNetwork() {

            File.Delete("ann");
            List<uint> layers = new List<uint>();
            layers.Add(24);
            layers.Add(3);
            layers.Add(2);

            NeuralNet net = new NeuralNet(NetworkType.LAYER, layers);

            net.SetActivationFunctionLayer(ActivationFunction.SIGMOID_SYMMETRIC, 1);
            net.SetActivationFunctionLayer(ActivationFunction.SIGMOID_SYMMETRIC, 2);

            net.TrainingAlgorithm = TrainingAlgorithm.TRAIN_RPROP;
            net.TrainOnFile("withSpace.txt", 100000, 10, 0.00001f);
            net.Save("ann");
        }

        public static void test() {
            float[][] tests = new float[][]{
                new float[]{1, 6, 4 ,12 ,5, 5, 3, 4, 1, 67, 3 ,2, 1, 2, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1}, //good
                new float[] { 2, 48, 2 ,60, 1 ,3 ,2, 2 ,1, 22, 3 ,1, 1, 1 ,1, 0, 0 ,1, 0 ,0, 1 ,0, 0 ,1 }, //bad
                new float[] {4 ,12, 4 ,21 ,1, 4, 3 ,3, 1 ,49 ,3, 1, 2, 1 ,1, 0, 0 ,1, 0, 0, 1 ,0, 1 ,0},//good
                new float[] { 2, 12, 2, 16 ,1, 3, 2 ,1 ,3 ,22 ,3 ,1, 1, 2, 1, 0, 0, 1, 0 ,0 ,1 ,0, 0, 1 }, //bad
                new float[] { 1, 42 ,2 ,79, 1, 4, 3 ,4 ,2 ,45 ,3, 1 ,2 ,1 ,1 ,0 ,0, 0 ,0, 0, 0 ,0 ,0 ,1 }, //good
            };

            NeuralNet fann = new NeuralNet("ann");
            //foreach (float[] test in tests) {
            //    Console.WriteLine(showResult(fann.Run(test)));
            //}
            // Console.WriteLine("{0, -7}{1,-12}{2, -13}{3, -10}", "Доход", "Ст. машины", "Недвижисомть", "Выдавать кредит?");

            foreach (float[] test in tests) {
                //Console.WriteLine("{0, -7}{1,-12}{2, -13}{3, -10}\n", test[0], test[1], test[24], showResult(fann.Run(test)));
                Console.WriteLine(showResult(fann.Run(test)));
            }
        }

        /// <summary>
        /// Function, witch show result after wark neural netwark
        /// </summary>
        /// <param name="out1">the output of the neural network</param>
        /// <returns>yes or no</returns>
        private static string showResult(float[] out1) {

            int i = 0;
            Console.WriteLine("длина выхода: " + out1.Length);
            for (int j = 1; j < 2; j++) {
                if (out1[i] < out1[j]) {
                    i = j;
                } else if (out1[i] > out1[j]) {

                }
            }
            switch (i) {
                case 0: return "Да";
                case 1: return "Нет";

            }
            return "";
        }


    }
}
