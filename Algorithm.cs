using test;
using System;

class geneticAlgorithm
{
    private const double MinValue = 0;
    private const double MaxValue = 16384; // Domain of the test function. -5<x,y<5 ===> domain=10  2^13<10000<2^14 ===> 2^14 = 16384

    public double[] fitnessedList = { };
    private static Random random = new Random();
    public double[][] populationList;
    public int generationCountIndex;
    public double bestFuncValue; 
    public double[] start(int popsize, double mutrate, double crossoverRate, int generationCount)
    {
        double[] bestIndividual = null;
        int generation = 0;

        var population = GeneratePopulation(popsize, mutrate);
        populationList = population;

        while (generation < generationCount && bestIndividual == null)
        {
            var fitnessScores = CalculateFitness(population, popsize, mutrate);
            bestIndividual = GetBestIndividual(population, fitnessScores);
            fitnessedList = fitnessScores;
            population = CreateNewGeneration(population, fitnessScores, popsize, mutrate, crossoverRate);
            generation++;
            
        }
        generationCountIndex = generation;
        bestFuncValue = fitnessedList.Min();
        return bestIndividual;
    }

    private static double[][] GeneratePopulation(int popsize, double mutrate)
    {
        double[][] population = new double[popsize][];
        for (int i = 0; i < popsize; i++)
        {
            population[i] = new double[2];
            population[i][0] = random.NextDouble() * (MaxValue - MinValue) + MinValue;
            population[i][1] = random.NextDouble() * (MaxValue - MinValue) + MinValue;
        }
        return population;
    }

    private static double[] CalculateFitness(double[][] population, int popsize, double mutrate)
    {
        var fitnessScores = new double[popsize];
        for (int i = 0; i < popsize; i++)
        {
            fitnessScores[i] = FitnessFunction(population[i]);
        }

        return fitnessScores;
    }

    private static double FitnessFunction(double[] values)
    {
        double x = values[0];
        double y = values[1];
        double a = -20 * (Math.Exp(-0.2 * Math.Sqrt(0.5 * ((x * x) + (y * y))))) - (Math.Exp(0.5 * (Math.Cos(2 * Math.PI * x) + Math.Cos(2 * Math.PI * y)))) + Math.E + 20;
        return a; 
    }

    private static double[] GetBestIndividual(double[][] population, double[] fitnessScores)
    {
        double minFitness = fitnessScores.Min();
        
        int index = Array.IndexOf(fitnessScores, minFitness); 
        return population[index]; 
    }

    private static double[][] CreateNewGeneration(double[][] oldPopulation, double[] fitnessScores, int popsize, double mutrate,double crossoverRate)
    {
        var newPopulation = new double[popsize][]; 
        for (int i = 0; i < popsize; i++)
        {
            double[] parent1 = SelectParent(oldPopulation, fitnessScores,popsize);
            double[] parent2 = SelectParent(oldPopulation, fitnessScores, popsize);
            double[] child = Crossover(parent1, parent2,crossoverRate);
            Mutate(child,mutrate);
            newPopulation[i] = child;
        }
        return newPopulation;
    }

    private static double[] SelectParent(double[][] population, double[] fitnessScores,int popsize)
    {
        double totalFitness = fitnessScores.Sum();
        double randomValue = random.NextDouble() * totalFitness;
        double cumulativeFitness = 0;
        for (int i = 0; i < popsize; i++)
        {
            cumulativeFitness += fitnessScores[i];
            if (cumulativeFitness >= randomValue)
            {
                return population[i];
            }
        }
        return population[popsize - 1];
    }

    private static double[] Crossover(double[] parent1, double[] parent2,double crossoverRate)
    {
        double crossoverPoint = random.Next(1, parent1.Length - 1);
        var child = new double[parent1.Length];
        if(crossoverPoint < crossoverRate)
        {
            for (double i = crossoverPoint; i < crossoverPoint; i++)
            {
                child[(int)i] = parent1[(int)i];
            }
            for (double i = crossoverPoint; i < parent1.Length; i++)
            {
                child[(int)i] = parent2[(int)i];
            }
        }
        
        return child;
    }

    private static void Mutate(double[] individual, double mutrate)
    {
        for (int i = 0; i < individual.Length; i++)
        {
            if (random.NextDouble() < mutrate) 
            {
                individual[i] += (random.NextDouble() - 0.5) * (MaxValue - MinValue) * 0.1; 
                individual[i] = Math.Min(MaxValue, Math.Max(MinValue, individual[i])); 
            }
        }
    }
}