using MyUnit;
using Task5.Tests;

TestRunner.OnTestFailure += (name, message) =>
    Console.WriteLine(
        $"-NOT PASSED: {name}{(string.IsNullOrWhiteSpace(message) ? string.Empty : $"\n Message: {message}")}");
TestRunner.OnTestPass += (name, message) =>
    Console.WriteLine(
        $"+PASSED: {name}");

TestRunner.Run(typeof(BulletTest));
TestRunner.Run(typeof(MagazineTest));
TestRunner.Run(typeof(RifleTest));