﻿// See https://aka.ms/new-console-template for more information
using Supermercado;

Console.WriteLine("PRODUCTS");
Console.WriteLine("------------------------------------------------------------");
Product product1 = new FixedPriceProduct() {
    Description = "Vino Gato Negro",
    Id = 1010,
    Price = 46000M,
    Tax = 0.19F
};
Product product2 = new FixedPriceProduct() {
    Description = "Pan Bimbo Artesanal",
    Id = 2020,
    Price = 1560M,
    Tax = 0.19F
};
Console.WriteLine(product1);
Console.WriteLine(product2);

Product product3 = new VariablePriceProduct()
{
    Description = "Queso Holandes",
    Id = 3030,
    Measurement = "Kilo",
    Price = 32000M,
    Quantity = 0.536F,
    Tax = 0.19F
};

Console.WriteLine(product3);
