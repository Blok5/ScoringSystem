using FANNCSharp.Float;

namespace ScoringSystem.NeuralNetwork {
    class NeuralNetwork {

        public static float o1;
        public static float o2;

        /// <summary>
        /// Function, return the output of the neural network
        /// </summary>
        /// <param name="creditData">Arrray with credit and client data in correct format
        /// for neural network</param>
        /// <returns>result (yes/no)</returns>
        public static string assessCreditworth(float[] creditData) {
            NeuralNet fann = new NeuralNet("ann");

            string result = showResult(fann.Run(creditData));

            

            return result;
        }

        /// <summary>
        /// Function, witch show result after wark neural netwark
        /// </summary>
        /// <param name="out1">the output of the neural network</param>
        /// <returns>yes or no</returns>
        private static string showResult(float[] out1) {

            int i = 0;
           
            for (int j = 1; j < 2; j++) {
                if (out1[i] < out1[j]) {
                    i = j;
                } else if (out1[i] > out1[j]) {

                }
            }
            o1 = out1[0];
            o2 = out1[1];

            switch (i) {
                case 0: return "Да";
                case 1: return "Нет";

            }
            return "";
        }


    }
}
