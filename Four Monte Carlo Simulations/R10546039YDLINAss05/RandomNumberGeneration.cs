using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R10546039YDLINAss05
{
    public class RandomNumberGeneration
    {
        int Result = 0;
        List<double> SAN = new List<double>();
        // Radnom Matrix
        public int RandomMatrix(int Replication, int seed)
        {
            long CalculateMatrix = 0;
            long[,] matrix;
            Random r = new Random(seed);
            // here is replication
            for (int i = 0; i < Replication; i++)
            {
                matrix = new long[3, 3]; // we new a new matrix 3, 3
                for (int j= 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        long randomNumber = r.Next(0, Replication);
                        matrix[j, k] = randomNumber;
                    }
                }
                CalculateMatrix = (matrix[0, 0] * matrix[1, 1] * matrix[2, 2]) - (matrix[0, 1] * matrix[1, 2] * matrix[2, 0]) -
                         (matrix[0, 2] * matrix[1, 0] * matrix[2, 1]) - (matrix[2, 0] * matrix[1, 1] * matrix[0, 2]) -
                         (matrix[2, 1] * matrix[1, 2] * matrix[0, 0]) - (matrix[2, 2] * matrix[1, 0] * matrix[0, 1]);
                if(CalculateMatrix > 0)
                {
                    Result++;
                }
            }
            return Result;
        }


        //Gambling Craps
        public int GamblingCraps(int Replication, int seed)
        {
            Random r = new Random(seed);
            for (int i = 0; i < Replication; i++)
            {
                // here we dice, the first and second
                int first = r.Next(1, 7);
                int second = r.Next(1, 7);
                int sum = first + second;
                // if the sum is 2, 3, or 12, the result += 0, means no win
                if(sum == 2 || sum == 3 || sum == 12)
                {
                    Result += 0;
                }
                //if sum is 7 or 11, means win, the result add 1
                else if (sum == 7 || sum == 11)
                {
                    Result++;
                }
                // others that we need to repeat until win or not win
                else
                {
                    int point = sum; // we need to set a point, that the rule need
                    do
                    {
                        first = r.Next(1, 7);
                        second = r.Next(1, 7);
                        sum = first + second;
                    }
                    while (sum != 7 && sum != point);
                    if(sum == 7)
                    {
                        Result += 0;
                    }
                    else if(sum == point)
                    {
                        Result++;
                    }
                }
            }
            return Result;
        }
        //Hatcheck Girl
        public int HatcheckGirl(int Replication,int NumberofCustomer, int seed)
        {
            Random r = new Random(seed);
            int[] Sequece = new int[NumberofCustomer];
            int RandomPosition;
            int temp; // here record the temporary
            for (int i = 0; i < Replication; i++)
            {
                // begin the incorrect is 0
                int incorrect = 0;
                for (int k = 0; k < NumberofCustomer; k++)
                {
                    Sequece[k] = k;
                }
                // here we shuffle and exchange the position
                for (int j = 0; j < NumberofCustomer; j++)
                {
                    RandomPosition = r.Next(j, NumberofCustomer);
                    temp = Sequece[RandomPosition];
                    Sequece[RandomPosition] = Sequece[j];
                    Sequece[j] = temp;
                    // here we count the incorrct 
                    if (Sequece[j] != j)
                    {
                        incorrect++;
                    }
                }
                // to check whether the incorrect number equal to the number of customer
                if (incorrect == NumberofCustomer)
                {
                    Result++;
                    
                }
            }
            return Result;
        }

        // stochastic Activity NetWork
        public List<double> StochasticActivityNetWork(int Replication, int seed, int Numberofpath, List<List<int>> pathlengths)
        {
            Random r = new Random(seed);
            double[] longpath = new double[Numberofpath];
            double[] completetime = new double[Replication];
            List<double> times = new List<double>();
            
            for (int i = 0; i < Numberofpath; i++)
            {
                longpath[i] = 0;
            }
            for (int i = 0; i < Replication; i++)
            {
                for (int j = 0; j < Numberofpath; j++)
                {
                    double time = 0;
                    for (int k = 1; k < pathlengths[j].Count; k++)
                    {
                        time += (pathlengths[j][k] * r.NextDouble());
                    }
                    times.Add(time);
                    completetime[i] = times.Max();
                }
                longpath[times.IndexOf(times.Max())]++;
                times.Clear();
            }
            SAN.Add(completetime.Average());
            for (int i = 0; i < Numberofpath; i++)
            {
                SAN.Add(longpath[i]);
            }
            return SAN;
        }

    }



}
