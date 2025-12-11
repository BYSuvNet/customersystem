using CustomerSystem.UI.Views;

//Skapa de objekt som behövs, knyt ihop dem och starta huvudmenyn
new MainMenuView(new InMemoryCustomerRepository()).Show();