using System;

class Program {
  public static void Main (string[] args) {
    string firstName = "Nathan";
    string lastName = "Esmaya";
    int age = 19;
    string gender = "Male";
    string address = "Malolos, Bulacan";
    Console.WriteLine ($"Hello World {firstName} {lastName} {age} {gender} {address}");
    Console.WriteLine ("Hello World" + " " + firstName + " " + lastName + " " + age + " " + gender + " " + address);
  }
}