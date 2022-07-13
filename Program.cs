//Borås djurpark vill förbättra besökarupplevelsen och har bestämt sig för att
//skaffa flera djur. Det planerar att få tag på en giraff, ett lejon, en struts,
//en puma, en antilop, en orangutang och en chimpans.
//Vår uppgift är att skapa en applikation som listar alla dessa djur så att man kan köpa dem.

using ZooTest;

ZooManager zm = new ZooManager();

zm.ShowAnimalList();
zm.PurchaseAnimal();
