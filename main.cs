using System;

class Program {
  public static void Main (string[] args) {
    string firstName = "Nathan";
    string lastName = "Esmaya";
    int age = 19;
    string address = "Malolos, Bulacan";
    Console.WriteLine ($"Hello World {firstName} {lastName} {age} {address}");
    Console.WriteLine ("Hello World" + " " + firstName + " " + lastName + " " + age + " " + address);
  }
}