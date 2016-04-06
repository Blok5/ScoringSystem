using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FANNCSharp.Float;
using FANNCSharp;
namespace ScoringSystem.NeuralNetwork {
    class NeuralNetwork {

        public static NeuralNet getFann() {

            List<uint> layers = new List<uint>();
            layers.Add(3); // inputs
            layers.Add(3); // hidden
            layers.Add(1); // output

            NeuralNet fann = new NeuralNet(NetworkType.LAYER, layers); // Тип, когда каждый нейрон может подключаться
            //только к нейрону следущего уровня.
            fann.SetActivationFunctionLayer(ActivationFunction.SIGMOID_SYMMETRIC, 1);
            fann.SetActivationFunctionLayer(ActivationFunction.SIGMOID_SYMMETRIC, 2);

            
            try {
                TrainingData td = new TrainingData("LearnData.txt");
                fann.TrainOnFile("LearnData", 100000, 10000, 0.001f);
                fann.TrainingAlgorithm = TrainingAlgorithm.TRAIN_RPROP;
                fann.Save("ann");

            } catch (Exception ex) {
                MessageBox.Show("Не могу открыть файл " + ex.Message + ex.Source);   
            }
           

            return fann;
        }

        
        
    }
}
