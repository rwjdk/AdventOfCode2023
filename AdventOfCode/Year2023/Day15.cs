﻿using Utils;

namespace Year2023;

//https://adventofcode.com/2023/day/15
public class Day15
{
    private const string Day = "Day15";

    //TODO: Add Part 1 Description
    [Theory]
    [InlineData($"{Day}_Sample.txt", 0)]
    [InlineData($"{Day}_Input.txt", 0)]
    public void Part1(string inputFile, int expectedAnswer)
    {
        int calculatedAnswer = 0;
        var inputLines = InputReader.ReadInputLines(inputFile);
        throw new NotImplementedException();
        Assert.Equal(expectedAnswer, calculatedAnswer);
    }

    //TODO: Add Part 2 Description
    [Theory]
    [InlineData($"{Day}_Sample.txt", 0)]
    [InlineData($"{Day}_Input.txt", 0)]
    public void Part2(string inputFile, int expectedAnswer)
    {
        int calculatedAnswer = 0;
        var inputLines = InputReader.ReadInputLines(inputFile);
        throw new NotImplementedException();
        Assert.Equal(expectedAnswer, calculatedAnswer);
    }
}

public static class Day15Extensions
{
}