using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RLS.AwesomeBar.API.Database.Migrations
{
    public partial class solutions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Beer");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Cocktail");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Cocoa");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Coffee / Tea");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Homemade Liqueur");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Milk / Float / Shake");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Ordinary Drink");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Other/Unknown");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Punch / Party Drink");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Shot");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Soft Drink / Soda");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "151 proof rum");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "7-Up");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Absinthe");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Absolut Citron");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Absolut Kurant");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Absolut Peppar");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Absolut Vodka");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Advocaat");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Agave syrup");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Agave Syrup");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ale");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Allspice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Almond");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Almond flavoring");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Amaretto");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Angelica root");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Angostura bitters");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Angostura Bitters");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Anis");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Anise");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Anisette");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Aperol");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apfelkorn");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apple");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apple brandy");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apple cider");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apple juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apple schnapps");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Applejack");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apricot");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apricot brandy");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apricot Brandy");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Aquavit");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Asafoetida");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "A�ejo rum");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Bacardi Limon");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Bailey");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Baileys irish cream");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Banana");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Banana liqueur");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Beer");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Benedictine");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Berries");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Bitter lemon");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Bitters");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Black pepper");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Black Sambuca");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blackberries");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blackberry brandy");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blackcurrant cordial");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blackcurrant squash");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "blackstrap rum");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blended Scotch");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blended whiskey");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blue Curacao");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blueberry schnapps");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Bourbon");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Brandy");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Brown sugar");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Butter");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Butterscotch schnapps");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cachaca");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Campari");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Candy");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cantaloupe");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Caramel coloring");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "caramel sauce");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Carbonated soft drink");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Carbonated water");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cardamom");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Carrot");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cayenne pepper");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Celery salt");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chambord raspberry liqueur");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Champagne");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherries");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherry");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherry brandy");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherry Grenadine");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherry Heering");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherry liqueur");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate ice-cream");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate liqueur");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate milk");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "chocolate sauce");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate Sauce");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate syrup");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cider");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cinnamon");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cloves");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Club soda");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coca-Cola");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cocoa powder");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coconut liqueur");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coconut milk");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coconut rum");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coconut syrup");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coffee");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coffee brandy");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coffee liqueur");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cognac");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cointreau");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Condensed milk");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coriander");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Corn syrup");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cornstarch");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Corona");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cranberries");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cranberry juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cranberry Juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cranberry vodka");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cream");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cream of coconut");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Creme de Banane");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Creme de Cacao");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Creme de Cassis");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Creme de Mure");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Crown Royal");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cumin seed");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Curacao");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Daiquiri mix");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dark Creme de Cacao");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dark rum");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dark Rum");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "demerara Sugar");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dr. Pepper");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Drambuie");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dry Vermouth");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dubonnet Rouge");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Egg");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Egg white");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Egg White");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Egg yolk");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Egg Yolk");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Elderflower cordial");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Erin Cream");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Espresso");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Everclear");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Falernum");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fennel seeds");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Firewater");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Food coloring");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Frangelico");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fresca");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fresh Lemon Juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fresh Lime Juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fruit");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fruit juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fruit punch");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Galliano");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "gin");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Gin");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ginger");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ginger ale");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ginger beer");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ginger Beer");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ginger Syrup");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Glycerine");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Godiva liqueur");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Gold rum");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Gold tequila");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Goldschlager");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grain alcohol");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grand Marnier");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grape juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grape soda");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grape Soda");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grapefruit juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grapefruit Juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grapes");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Green Chartreuse");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Green Creme de Menthe");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grenadine");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Guava juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Guinness stout");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Half-and-half");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Heavy cream");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Honey");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Honey syrup");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Hot chocolate");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Hot Chocolate");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Hot Damn");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Iced tea");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Irish cream");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Irish whiskey");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Irish Whiskey");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Islay single malt Scotch");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Jack Daniels");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Jagermeister");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Jello");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Jim Beam");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Johnnie Walker");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "J�germeister");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kahlua");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kirschwasser");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kiwi");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kiwi liqueur");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kool-Aid");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kummel");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lager");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lavender");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "lemon");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "lemon juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon Juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon peel");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon vodka");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon-lime soda");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemonade");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Licorice root");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Light cream");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Light rum");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lillet");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lillet Blanc");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime Juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime juice cordial");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime peel");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime vodka");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Limeade");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Malibu rum");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mango");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maple syrup");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maraschino cherry");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maraschino Cherry");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "maraschino liqueur");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maraschino liqueur");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maraschino Liqueur");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Marjoram leaves");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Marshmallows");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maui");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Melon liqueur");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mezcal");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Midori melon liqueur");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Milk");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mini-snickers bars");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mint");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mint syrup");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mountain Dew");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Nutmeg");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Olive");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Olive Brine");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange bitters");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange Bitters");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange Curacao");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "orange juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange Juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange peel");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange Peel");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange spiral");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Oreo cookie");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orgeat syrup");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ouzo");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Papaya");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Passion fruit juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Passion fruit syrup");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Passoa");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peach Bitters");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peach brandy");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peach nectar");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peach schnapps");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peach Vodka");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peachtree schnapps");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pepper");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peppermint extract");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peppermint schnapps");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pepsi Cola");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pernod");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peychaud bitters");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pina colada mix");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pineapple");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "pineapple juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pineapple juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pineapple Juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pineapple Syrup");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pink lemonade");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pisang Ambon");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pisco");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Port");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Powdered sugar");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Prosecco");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Raspberry Liqueur");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Raspberry syrup");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Raspberry vodka");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Red wine");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ricard");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Root beer");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Rosemary");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Rosso Vermouth");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Rum");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Rumple Minze");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Rye whiskey");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Salt");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Salted Chocolate");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sambuca");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sarsaparilla");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Schweppes Russchian");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Scotch");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sherbet");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sherry");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sirup of roses");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sloe gin");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Soda water");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Soda Water");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sour mix");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Southern Comfort");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Spiced rum");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sprite");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "St. Germain");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Strawberries");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Strawberry liqueur");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Strawberry schnapps");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sugar");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sugar syrup");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sugar Syrup");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Surge");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sweet and sour");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sweet and Sour");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sweet Vermouth");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tabasco sauce");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tea");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tennessee whiskey");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tequila");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tia maria");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tomato juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tomato Juice");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tonic water");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tonic Water");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Triple sec");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Triple Sec");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tropicana");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vanilla");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vanilla extract");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vanilla ice-cream");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vanilla Ice-Cream");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vanilla vodka");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vermouth");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vodka");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Water");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Whipped cream");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Whipped Cream");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Whipping cream");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Whiskey");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Whisky");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "White Creme de Menthe");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "White rum");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "White Rum");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Wild Turkey");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Wine");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Worcestershire sauce");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Wormwood");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Yellow Chartreuse");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Yoghurt");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Yukon Jack");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Zima");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Ingredients",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<Guid>(
                name: "ID",
                table: "Ingredients",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<Guid>(
                name: "ID",
                table: "Categories",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Cocktails",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    AlternateName = table.Column<string>(type: "TEXT", nullable: true),
                    Tags = table.Column<string>(type: "TEXT", nullable: true),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    Instructions = table.Column<string>(type: "TEXT", nullable: true),
                    Image = table.Column<string>(type: "TEXT", nullable: true),
                    Ingredients = table.Column<string>(type: "TEXT", nullable: true),
                    Measures = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cocktails", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c9e1fa20-02f0-4d86-b457-303633f7d1c4"), new DateTime(2021, 5, 18, 17, 40, 58, 927, DateTimeKind.Utc).AddTicks(8002), "Cocktail", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("50ee95e6-321d-4591-ac30-4dc3bd1b6a0c"), new DateTime(2021, 5, 18, 17, 40, 58, 929, DateTimeKind.Utc).AddTicks(5059), "Soft Drink / Soda", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b9abe77c-8531-4a3e-9736-388ff2feec06"), new DateTime(2021, 5, 18, 17, 40, 58, 929, DateTimeKind.Utc).AddTicks(4977), "Beer", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3548306d-8a29-4c37-a3b0-6366446ae7b5"), new DateTime(2021, 5, 18, 17, 40, 58, 929, DateTimeKind.Utc).AddTicks(4707), "Coffee / Tea", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("01f97c09-cf6f-4a38-bc8e-5f042e3cc72e"), new DateTime(2021, 5, 18, 17, 40, 58, 929, DateTimeKind.Utc).AddTicks(3552), "Shot", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("42864bba-2223-4845-8f51-f1cffb0b4fc7"), new DateTime(2021, 5, 18, 17, 40, 58, 929, DateTimeKind.Utc).AddTicks(4849), "Homemade Liqueur", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("89bdc859-684b-435f-a423-52b601285fb0"), new DateTime(2021, 5, 18, 17, 40, 58, 929, DateTimeKind.Utc).AddTicks(3426), "Other/Unknown", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("73528485-83e6-4dee-8465-ac38745196de"), new DateTime(2021, 5, 18, 17, 40, 58, 929, DateTimeKind.Utc).AddTicks(3392), "Milk / Float / Shake", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cd9ac00a-8203-4196-aaee-b3794e14964a"), new DateTime(2021, 5, 18, 17, 40, 58, 929, DateTimeKind.Utc).AddTicks(2654), "Punch / Party Drink", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ee04c6d5-0323-4f72-8f82-a1bf1f652b11"), new DateTime(2021, 5, 18, 17, 40, 58, 929, DateTimeKind.Utc).AddTicks(2424), "Ordinary Drink", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("68f0da2e-3fd6-4d3c-ae6b-3a48bf7fa97b"), new DateTime(2021, 5, 18, 17, 40, 58, 929, DateTimeKind.Utc).AddTicks(3513), "Cocoa", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7c478a7e-5497-4dae-b5fd-20b9e50dcf5e"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/3k9qic1493068931.jpg", "Vodka, Pisang Ambon, Apple juice, Lemon juice, Lemonade", "Fill a tall glass with ice. Layer the Finlandia Vodka, lemon and apple juices, Pisang Ambon, and top up with lemonade. Stir slightly and garnish with a spiralled cucumber skin and a red cherry. The cucumber provides zest and looks attractive. This drink, created by Timo Haimi, took first prize in the 1991 Finlandia Vodka Long Drink Competition.", "3 parts, 1 part, 6 parts, 1 1/2 part", "Avalon", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("180bd200-9b08-4d12-96f1-c2946361c9b3"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/xk79al1493069655.jpg", "Chocolate ice-cream, Brandy, Amaretto", "Combine all ingredients in a blender and blend at high speed until smooth. Serve in chilled glass garnished with bittersweet chocolate shavings.", "2 scoops, 2 oz, 2 oz", "Amaretto Shake", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("0fee4a00-7355-42df-9901-4a1acecbd9a4"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/trptts1454514474.jpg", "Coconut rum, Amaretto, Orange juice, Grenadine", "Shake Rum, Amaretto, and Orange Juice in a shaker filled with ice. Strain over ice into a highball glass. Add Grenadine and garnish with a Pineapple Wedge and a Strawberry.", "1 oz, 1/2 oz, 4 oz, 1/2 oz", "A Day at the Beach", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4d571b6d-3333-4fd4-bbf6-4fd0e9e3c251"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/2dwae41504885321.jpg", "Malibu rum, Tropicana, Cranberry juice", "Add rum & trister then, add cranberry jucie,stir", "2 parts, 2 parts, 1 part", "Malibu Twister", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("59c1ec88-de79-4aa1-af75-04c86e7ea750"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vxtjbx1504817842.jpg", "151 proof rum, Malibu rum, Pineapple juice, Orange juice, Grenadine, Cherries", "Fill glass with ice and add shots of Bacardi and Malibu. Add splash of pineapple juice and top with orange juice. Add grenadine for color and garnish with cherries.", "1 shot Bacardi, 1 shot, 1 shot", "Space Odyssey", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d80fb603-e6fc-45b2-8066-83dd98f3e37a"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/qyuvsu1479209462.jpg", "J�germeister, Root beer", "Mix together and enjoy", "1/2 oz, 1/2 oz", "Zenmeister", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("dba50061-7c4b-4b61-a1e0-e88586aec143"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/rtpxqw1468877562.jpg", "151 proof rum, Wild Turkey", "Add both ingredients to shot glass, shoot, and get drunk quick", "1/2 shot Bacardi, 1/2 shot", "252", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d3e42aca-c8ba-4d79-8ef0-96837e9a061d"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/uxywyw1468877224.jpg", "Absolut Kurant, Grand Marnier, Chambord raspberry liqueur, Midori melon liqueur, Malibu rum, Amaretto, Cranberry juice, Pineapple juice", "Shake ingredients in a mixing tin filled with ice cubes. Strain into a rocks glass.", "1/2 oz, 1/4 oz, 1/4 oz, 1/4 oz, 1/4 oz, 1/4 oz, 1/2 oz, 1/4 oz", "1-900-FUK-MEUP", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("024239fc-d0f0-4343-92f1-0d55d106d189"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/kvvd4z1485621283.jpg", "Sambuca, Baileys irish cream, White Creme de Menthe", "add all and pour black coffee and add whipped cream on top.", "2 cl, 2 cl, 2 cl", "Zorro", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b6468801-c09a-4a32-82a2-c6c57cd57556"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/zvoics1504885926.jpg", "Vodka, Triple sec, Orange juice", "Add all ingredients to tumbler-Pour as shot", "1 oz, 1 oz, 1 oz", "Orange Crush", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("82b81872-fa5d-4c93-8f05-928c52e01508"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/yqvvqs1475667388.jpg", "Dark rum, Light rum, Vodka, Orange juice", "Blend with ice. Serve in a wine glass. Garnish with carrot.", "1 shot, 2 shots, 1 shot, 1 shot", "155 Belmont", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("9f313d28-ba3e-458b-afa8-82c611a9e97a"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/szmj2d1504889961.jpg", "Vodka, Creme de Banane, Grenadine, Orange juice", "Take a tall glass and put in a few ice cubes, fill the vodka over it and fill with juice then the \"creme\", to end fill in the grenadine but very carefully at the side of the glass so it will lay down in the bottom. garnish with orange and strawberry.", "2 cl, 2 cl", "San Francisco", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7ef0a5b3-143a-4801-bdff-ce59f5c3dc87"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/rpttur1454515129.jpg", "Vodka, Schweppes Russchian", "Mix it as a ordinary drink .", "2 oz", "Vodka Russian", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c8db5f9f-0c80-4bd1-9a24-816599c465d3"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/vurrxr1441246074.jpg", "Coffee, Everclear", "pour it in and mix it.", "3 parts, 1 part", "Danbooka", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("0217a6d8-e520-4fde-b116-4bc2edd6557c"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/rrtssw1472668972.jpg", "Gin, Light rum, Tequila, Triple sec, Vodka, Coca-Cola, Sweet and sour, Bitters, Lemon", "Fill 14oz glass with ice and alcohol. Fill 2/3 glass with cola and remainder with sweet & sour. Top with dash of bitters and lemon wedge.", "1/2 oz, 1/2 oz, 1/2 oz, 1/2 oz, 1/2 oz, 1-2 dash, 1 wedge", "3-Mile Long Island Iced Tea", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f03a7e18-787d-4dcd-b602-dc7d857004cd"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/xrl66i1493068702.jpg", "Vodka, Creme de Banane, Orange juice", "Pour the vodka and creme over some ice cubes in a tall glass and fill up with juice. to make it beuty full make the top of the glass with a grenadine and sugar", "2 cl, 1 cl", "After sex", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("68d00b4d-013f-4c99-ae0d-1a92324ff558"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/7rnm8u1504888527.jpg", "Crown Royal, Peach schnapps, Chambord raspberry liqueur, Cranberry juice", "Pour all the ingredients into tumbler over ice. Strain into glass.", "1 1/2 oz, 1 oz, 1/2 oz, 1 oz", "Royal Flush", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("8ab4f524-bb36-4420-97b6-355d5fc60abf"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/uptxtv1468876415.jpg", "Orange juice, Grapefruit juice, Apple juice, Maraschino cherry", "Stirr. Grnish with maraschino cherry.", "4 cl, 3 cl, 1 cl, 1", "Apello", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("8500c1ae-5e29-4350-bb4f-2b0a212467f8"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/spuurv1468878783.jpg", "Vodka, Banana liqueur, Orange juice, Peach schnapps", "Layer in order into a shot glass.", "1/4, 1/4, 1/4, 1/4", "Bubble Gum", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d843c202-1963-465d-b792-c8164399d7e4"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/tpupvr1478251697.jpg", "Kiwi liqueur, Bitter lemon, Ice", "Mix in highball glass. Stirr. Garnish with slice of kiwi.", "1 part, 2 parts, cubes", "Kiwi Lemon", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7ddc9fd8-5577-4d41-b502-dbb01f38a671"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/spvrtp1472668037.jpg", "Irish whiskey, Baileys irish cream, Coffee", "Combine all ingredients in glass", "1 shot, 3/4 shot, 6 oz hot", "Hot Creamy Bush", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d8cdda6a-b265-4cab-a48a-070be07cdc30"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/svuvrq1441208310.jpg", "Baileys irish cream, White Creme de Menthe, Cream", "If available, rim cocktail (Martini) glass with sugar syrup then dip into chocolate flakes or powder. Add ingredients into shaker with ice. Shake well then strain into cocktail glass.", "1 oz, 3/4 oz, 3/4 oz double", "Midnight Mint", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("feecca2c-2708-43c0-acd7-90e6459ab418"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/rswqpy1441246518.jpg", "Grand Marnier, Coffee", "Add your GM and then add your coffee.", "3 parts, 1 part", "Talos Coffee", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("ed5089ef-2224-4e99-ae87-2b08a65555b9"), null, "Soft Drink / Soda", "https://www.thecocktaildb.com/images/media/drink/iixv4l1485620014.jpg", "Peachtree schnapps, Surge", "Get a shot glass and pour in three shots of the schnapps. Do the same with the Surge Cola. Then down it like Scheetz would.", "4 shots, 4 shots", "Zinger", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("9da14dc3-0f68-426e-9404-1d2f5e508171"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/rtohqp1504889750.jpg", "Yukon Jack, Cherry brandy, Southern Comfort, Sweet and sour", "Mix all ingredients and Shake well. Sweet at first, with a BITE at the end...", "1 part, 1/2 part, 1 part, 1 splash", "Texas Rattlesnake", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("1b28c35d-6870-4e3a-9f06-dbf0c902b12d"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/l0smzo1504884904.jpg", "Vodka, Jello, Water", "Boil 3 cups of water then add jello. Mix jello and water until jello is completely disolved. Add the two cups of vodka and mix together. Pour mixture into plastic shot glasses and chill until firm. Then, eat away...", "2 cups, 3 packages, 3 cups", "Jello shots", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b66aa6ff-bc7f-48bb-953d-2100d6c1c38e"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/rxurpr1441554292.jpg", "Wild Turkey, Amaretto, Pineapple juice", "Shake with ice and strain into a shot glass.", "1 oz, 3/4 oz, 1 splash", "Turkeyball", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("ec101853-6139-4b4d-8e47-6e10fff0355e"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vqwstv1472811884.jpg", "Absolut Vodka, Cranberry juice, Ginger ale, Ice", "Stir ingredients together. Serve over ice.", "2 oz, 4 oz, 2 oz, Add", "Absolutely Cranberry Smash", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("79c5bb65-56bf-44e3-a2a5-40399692416a"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/m7iaxu1504885119.jpg", "Cranberry vodka, Apfelkorn, Schweppes Russchian, Apple juice, Ice", "mix in the glass", "4 cl, 2 cl, 7 cl, 8 cl, cubes", "Kiss me Quick", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("2712e68d-748f-41bb-87a6-5def5ca432ed"), null, "Beer", "https://www.thecocktaildb.com/images/media/drink/xxyywq1454511117.jpg", "Lager, Tequila", "Drop shooter in glass. Fill with beer", "16 oz, 1.5 oz", "110 in the shade", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("ee75f5f5-27d8-4623-a0c7-427a6b8c61ac"), null, "Beer", "https://www.thecocktaildb.com/images/media/drink/wwqrsw1441248662.jpg", "Corona, Bacardi Limon", "Open the Corona. Fill the empty space in the neck in the bottle with the rum. The bottle should be filled to the top. Plug the bottle with your thumb or the palm of your hand. Turn the bottle upside-down so the rum and beer mix. Turn the bottle rightside-up, unplug, and drink.", "1 bottle, 1 oz", "Limona Corona", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("3904d495-3a14-4edf-b5df-b28fc4d1b65c"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/xsqsxw1441553580.jpg", "Orange juice, Apple juice, Pineapple juice, Ice", "Shake with ice.", "1 part, 1 part, 1 part", "Pysch Vitamin Light", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("8a0d0976-643b-4b7f-8fd7-62b2db5fad81"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/wyrsxu1441554538.jpg", "Rum, Ginger ale, Fruit punch, Orange juice, Ice", "Mix all ingredients in a punch bowl and serve.", "mikey bottle, large bottle, 355 ml frozen, 355 ml frozen, crushed", "Rum Punch", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("78594c3f-ee99-446c-9699-245b8825c470"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vsrsqu1472761749.jpg", "Malibu rum, Peach schnapps, Blue Curacao, Sweet and sour", "Serve in an old fashioned glass.", "1 1/2 cl, 1 1/2 cl, 1 1/2 cl, 3 cl", "Grand Blue", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("88d6360c-88b5-4572-83de-1dbf10aa0f80"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/xuyqrw1472811825.jpg", "Absolut Vodka, Peach schnapps, Coconut liqueur, Cranberry juice, Pineapple juice", "Mix well. Garnish with Orange and Cherry. Enjoy", "1 1/2 oz, 1/2 oz, 1/2 oz, 1 1/2 oz, 1 1/2 oz", "Absolut Stress #2", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("8c1409c6-0758-4035-b231-d91351aac975"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/txruqv1441245770.jpg", "Coffee, Jack Daniels, Amaretto, Whipped cream", "Mix Coffee, Jack Daniels and Amaretto. Add Cream on top.", "8 oz, 4 oz, 4 oz", "Tennesee Mud", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("71f87c2f-d909-4446-8aaf-3c20d5fa3886"), null, "Milk / Float / Shake", "https://www.thecocktaildb.com/images/media/drink/xxtxsu1472720505.jpg", "Ice, Chocolate syrup, Cherry brandy, Vodka, Milk", "In a blender put ice cubes, chocolate syrup, cherry brandy, vodka, and milk. Blend very well.", "cubes", "Black Forest Shake", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("6351ecf4-af61-4088-915b-220780a17885"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vyxwut1468875960.jpg", "Galliano, Ginger ale, Ice", "Pour the Galliano liqueur over ice. Fill the remainder of the glass with ginger ale and thats all there is to it. You now have a your very own GG.", "2 1/2 shots", "GG", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("85f5d02f-335b-44af-ae25-a1d65063ced1"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/xz8igv1504888995.jpg", "Beer, 7-Up", "Pour beer into large mug, slowly add the 7-up (or Sprite).", "12 oz, 12 oz", "Radler", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("fb3a308b-69f1-415c-a3d1-4afed6b67a10"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/hepk6h1504885554.jpg", "Southern Comfort, Orange juice, Pepsi Cola", "Add all contents to a large jug or punch bowl. Stir well!", "750 ml, 1 L, 750 ml", "Mudslinger", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("94b43ad2-b918-4ec5-b927-ed90a2e4a87f"), null, "Beer", "https://www.thecocktaildb.com/images/media/drink/xsqrup1441249130.jpg", "Lager, Campari", "Use a 15 oz glass. Add Campari first. Fill with beer.", "1 bottle, 1 1/2 cl", "Campari Beer", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("bcc4ef0a-5ccb-4d03-86b3-943c89bd4e0d"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/jls02c1493069441.jpg", "Amaretto, Dark Creme de Cacao, Coffee", "Pour in order into coffee cup. Top with whipped creme and chocolate shcvings.", "3/4 oz, 1/2 oz, 8 oz", "Almond Chocolate Coffee", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b72796aa-c3f3-4a7f-a8c3-054da29e57f5"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/trwruu1478253126.jpg", "Campari, Sweet Vermouth, Lemon peel, Orange peel", "Pour the Campari and vermouth over ice into glass, add a splash of soda water and garnish with half orange slice.", "1 oz, 1 oz red, Twist of, Twist of", "Americano", "IBA,Classic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("22198d99-4139-4f69-87f2-0d507436fcea"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/wutxqr1472720012.jpg", "Sour mix, Amaretto, Tequila, Orange juice", "Shake sour mix, tequila and amaretto with ice. Strain into highball glass. Add a splash of OJ. Garnish with orange slice and a cherry.", "2 oz, 2 oz, 2 oz, Add splash", "Amaretto Stone Sour #3", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("52479cae-245f-45de-af8e-903770e88dca"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/yvxrwv1472669728.jpg", "Absolut Citron, Orange juice, Triple sec, Ginger ale", "Shake it up it tasts better that way, but you can stir it if you want. 6 of those and you will be wasted for the rest of the night.", "1 shot, 1 shot, 1 shot, Fill to top", "Absolutly Screwed Up", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("19aa3c53-591a-480d-b9da-a7e882f6b790"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/srpxxp1441209622.jpg", "Ice, Tequila, Cream of coconut, Lime juice", "Place all ingredients in a blender and blend until smooth. This makes one drink.", "1 cup, 2 oz, 1/4 cup, 3 tblsp fresh", "Whitecap Margarita", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("3cab40b4-a2f1-474f-86f9-a67ff6387189"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/3h9wv51504389379.jpg", "Ice, Vodka, Peach nectar, Peach schnapps, Lemon peel", "Add ice cubes to shaker.\r\nAdd vodka.\r\nAdd peach schnapps.\r\nAdd peach nectar.\r\nShake.\r\nStrain into glass.\r\nAdd lemon twist peel.", "8 cubes, 3 oz, 1.5 oz, 1.5 oz, 1", "Bellini Martini", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("8cec0339-be56-41ce-ac7d-822af2a11d21"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/wwqvrq1441245318.jpg", "Gin, Vodka, Grenadine, Lime juice, Sugar, Sugar syrup, Soda water", "Wet glass, dip rim in sugar. Then add Ice. Then add everything else. It's that simple!", "2 jiggers, 1 jigger, 3 dashes, 1 shot, Around rim put 1 pinch, 3 dashes, Fill to top with", "Jitterbug", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("03a60cf2-6929-48ad-83db-20966dd9c07b"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/urpsyq1475667335.jpg", "Absinthe, Tequila, Grenadine", "first you put rhe absinthe, then put tequila, then put the Granadine syrup.", "2/5, 2/5, 1/5", "Moranguito", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5163251d-4551-4e20-8feb-9b3b9c07fb75"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/vswwus1472668546.jpg", "Amaretto, Sweet and sour, Midori melon liqueur, Pineapple juice", "Fill the blender with 3/4 ice. Add sweet & sour mix to the top of the ice. Add about 1\" of pineapple juice, 1/2\" of melon liqeur, and 1/2 to 1/4\" of amaretto. Then blend the mix until it is of margaritta consistency or thinner.", "", "Amaretto Sweet & Sour", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("68667686-3342-4a4e-a2f6-0b5ce35d1ac8"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/xvwusr1472669302.jpg", "Absolut Citron, Orange Curacao, Strawberry liqueur, Orange juice", "Combine all ingredients in glass mixer. Chill and strain into Cocktail glass. Garnish with sliced strawberry.", "2 oz, 1/2 oz, 1 splash, 1 oz", "9 1/2 Weeks", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("954ea52a-41e5-4b0a-a700-1ba3208f6446"), null, "Milk / Float / Shake", "https://www.thecocktaildb.com/images/media/drink/wywrtw1472720227.jpg", "Kahlua, Milk, Vanilla ice-cream", "Leave ice-cream out for about 10 minutes. Add ingredients in order, stir with chopstick (butter knife or spoon works too). Consume immediately and often. Nice and light, great for following a heavy drink.", "2 oz, 8 oz, 2 scoops", "Baby Eskimo", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d8190436-da17-4a42-808c-ae006591b5a8"), null, "Soft Drink / Soda", "https://www.thecocktaildb.com/images/media/drink/bje5401485619578.jpg", "Sambuca, Root beer, Ice", "Mix sambuca with rootbeer and stir. Add ice", "1 1/2 oz, Add 10 oz, cubes", "Zambeer", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f3b67453-5e08-4c2e-9875-b7e039356a74"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/tuxxtp1472668667.jpg", "Apricot brandy, Champagne, Vodka, 7-Up, Orange juice", "Pour all ingrediants into a large punch bowl. Add ice and 4 oranges that are peeled and divided.", "1 qt, 4 fifth, 1 fifth, 4 L, 1/2 gal", "Apricot punch", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("bd781185-a126-4690-a8b0-181a27c9b585"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/ywtrvt1441246783.jpg", "Coffee, Aquavit, Sugar", "Pour the coffee in an ordinary coffee cup. Add the aquavit. Add sugar by taste. Stir and have a nice evening (morning)", "1 cup, 4 cl, By taste", "Swedish Coffee", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f4b7c1bf-6c67-41ba-880a-283f48bf75d5"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vtuyvu1472812112.jpg", "Vodka, Lemonade, Water, Sugar", "Fill blender up with ice. Fill half with Bartons Vodka. Put 10 tsp of sugar, add 1/2 can lemonade concentrate, fill to top with water. Blend for 60 seconds.", "1/2, 1/2 can, 1/2, 10 tsp", "Adam Sunrise", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("dbfe8d46-103d-4bc1-8d1d-3018a0a29ad7"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/tuppuq1461866798.jpg", "J�germeister, Sambuca, Vodka", "make it an ample size shot!!", "1/2 oz, 1/2 oz, 1/2 oz", "Freddy Kruger", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f4216c35-e7a5-4d4e-ab2c-77fe5f86db96"), null, "Milk / Float / Shake", "https://www.thecocktaildb.com/images/media/drink/tyvpxt1468875212.jpg", "Banana liqueur, Creme de Cacao, Chocolate ice-cream, Chocolate syrup, Chocolate milk, Whipped cream, Cherry, Banana", "blend liqeuors with ice-cream, milk and syrup. pour into parfait glass, top with whipped cream and garnish with banana and cherry.", "1 shot, 2 shots, 2 scoops, 1 oz, 4 oz, 1, 1, 1 piece", "Chocolate Monkey", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("1e9bb6ab-1467-4f44-b057-f222507e788e"), null, "Milk / Float / Shake", "https://www.thecocktaildb.com/images/media/drink/ypl13s1504890158.jpg", "Kahlua, Irish cream, Amaretto, 151 proof rum, Cream", "Blend with Ice until smooth. Serve in a tulip glass, top with whip cream.", "1/2 oz, 1/2 oz, 1/2 oz, 1/2 oz Bacardi, 1 oz", "Texas Sling", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("70bdb922-f61e-44b4-9cda-0e1069e0f59b"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/ysqvqp1461867292.jpg", "Vodka, Kirschwasser, Strawberry liqueur, Strawberries, Schweppes Russchian", "Mix the strawberrys in a blender Pour it together with the vodka,kirch and strawberry liquer over ice in a shaker. Shake well and pour in a highballglass. Fill up with the Russchian water", "2 oz, 1 oz, 1 tsp, 5", "A midsummernight dream", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("1e75581a-d251-4ac4-9f8c-ae08cf0af142"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/5a3vg61504372070.jpg", "Baileys irish cream, Grand Marnier, Kahlua", "Layer ingredients into a shot glass. Serve with a stirrer.", "1/3, 1/3, 1/4", "B-52", "IBA,NewEra" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("404d4531-ed80-4de9-bbc4-709371355c3c"), null, "Soft Drink / Soda", "https://www.thecocktaildb.com/images/media/drink/ft8ed01485620930.jpg", "Beer, Root beer, Lemonade, Coca-Cola, 7-Up, Creme de Cassis, Lemon", "No specific mixinginstructions, just poor every ingredient in one glass. The lemon goes with it.", "slice", "Zoksel", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a02eadcb-6f9d-4a5f-9694-bb1eaf74eaf4"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vprxqv1478963533.jpg", "Black Sambuca, Orange juice", "Simply add the orange juice, quite a quick pour in order to mix the sambucca with the orange juice. The juice MUST have fruit pulp!", "25 ml, Add 250 ml", "Quick-sand", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f180db12-1077-48d4-b12b-443283c48fef"), null, "Beer", "https://www.thecocktaildb.com/images/media/drink/rssvwv1441248863.jpg", "Lager, Cider, Blackcurrant squash", "Put blackcurrant squash in first up to about 1cm in glass. Then add the larger and cider one after another.", "1/2 pint, 1/2 pint, A little bit of", "Snakebite and Black", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("43368fbc-c7ce-463f-b14c-1a2fc0a705eb"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/bw8gzx1485619920.jpg", "Midori melon liqueur, Zima", "Pour Zima in a collins glass over ice and then pour the shot of Midori. Don't stir. Garnish with a cherry.", "1.5 oz, 12 oz", "Zimadori Zinger", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("153f5473-b35f-40d6-b1b2-2d99eb878b1f"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/rrstxv1441246184.jpg", "Hot Damn, Tea", "Pour Hot Damn 100 in bottom of a jar or regular glass. Fill the rest of the glass with sweet tea. Stir with spoon, straw, or better yet a cinnamon stick and leave it in.", "5 shots, very sweet", "Herbal flame", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b40fff99-7238-4695-ac55-7dcd1547fbfd"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/xqptps1441247257.jpg", "Rum, Coffee, Water, Whipped cream", "Stir the rum, coffee and water together. Top with the whipped cream. Sprinkle with a pinch of well ground coffee and drink with a straw.", "1/6 glass, 1/6 glass strong black, 1/2 glass cold", "Jamaican Coffee", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("793a3617-d2d2-473d-875d-2aa54aef15ae"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/vwxrsw1478251483.jpg", "Mint, Lemon juice, Dark rum, Club soda, Angostura bitters", "Put mint with lemon juice in a glas, mash the mint with a spoon, ice, rum & fill up with club soda. Top it with Angostura.", "1/2 handful, 3 cl, 1/8 L Jamaican, 1/8 L, 8 drops", "Mojito #3", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f0a85ad9-1f06-406f-8c8b-68973f5ba092"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/wrvpuu1472667898.jpg", "Coffee, Peach schnapps", "fill coffe mug half full of coffee. Fill the other half full of Peach Schnapps. Stir and drink while hot.", "1/2, 1/2", "Fuzzy Asshole", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7284c4a4-522a-45eb-a46b-32ab2d5b212a"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/kztu161504883192.jpg", "Kahlua, 151 proof rum, Grenadine", "Mix Kahlua and 151 in glass. Quickly add ice and pour grenadine over ice to give ice red tint.", "1 oz, 1 oz Bacardi, 1 dash", "Grim Reaper", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("2a9d876a-0099-4978-b210-f226057a192b"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/wwpyvr1461919316.jpg", "Vanilla vodka, Grand Marnier, Orange juice", "fill glass with crushed ice. Add vodka. Add a splash of grand-marnier. Fill with o.j.", "2 1/2 oz, 1 splash, Fill with", "50/50", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("626062e5-1dd8-4314-876b-612d80880503"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/xuxpxt1479209317.jpg", "151 proof rum, Wild Turkey", "Poor in the 151 first followed by the 101 served with a Coke or Dr Pepper chaser.", "1 oz Bacardi, 1 oz", "ACID", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5d625495-3816-401a-8d79-2ad4842880d1"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/sk3lr91493068595.jpg", "Peppermint schnapps, Kahlua, Baileys irish cream", "1. Pour Kahlua into shot glass to about 1/2 full. 2. Using a spoon(inverted), slowly pour in the Peppermint Schnapps until glass is about 3/4 full. Done correctly, the Schnapps will flow under the Kahlua for a clear layer. 3. Again using a spoon, but this time right side up, slowly top off the glass with a layer of Bailey's. Be careful to place the spoon right at the top of the Kahlua layer and to raise it as the glass fills up. Done correctly, this will provide a layer of Bailey's floating over the Kahlua. 4. Toss it down all at once for something like a Peppermint Pattie, WITH A BANG!!! NOTE: Best if all ingredients are chilled", "", "After Five", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c6577407-6a27-4141-aa00-d249b96b3c74"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/uqqurp1441208231.jpg", "Kahlua, Baileys irish cream, Goldschlager, Heavy cream, Coffee", "Fill a mixer with ice and add Baileys, Kahlua, Goldshlager, and cream. Shake for 5 seconds and Strain into a double rocks glass filled with ice. Add chilled coffee Stir and enjoy!", "1 oz, 1 oz, dash, 2 oz, 2 oz Hazlenut", "Midnight Manx", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a632c634-45ce-4c8a-af1b-cb897e6523a6"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/yt9i7n1504370388.jpg", "Creme de Cassis, Champagne", "Pour Creme de cassis in glass, gently pour champagne on top", "1 part, 5 parts", "Kir Royale", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7863bc81-c1f9-4c38-bafd-86ee4bb69a1f"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/9von5j1504388896.jpg", "Jack Daniels, Amaretto", "Serve over ice- Warning,Deadly!", "1 oz, 1 oz", "Jackhammer", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c156ec9d-fd84-433a-b400-17f111eca5ce"), null, "Milk / Float / Shake", "https://www.thecocktaildb.com/images/media/drink/xspupx1441248014.jpg", "Baileys irish cream, Frangelico, Milk", "Serve over ice", "1 part, 1 part, 1 part", "Nutty Irishman", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("e1db3e54-63d0-47a3-a1a5-f2d2ce735422"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/wxqpyw1468877677.jpg", "Jack Daniels, Johnnie Walker, Jim Beam", "put them them in a glass... and slam it to tha head.", "1/3 oz, 1/3 oz, 1/3 oz", "3 Wise Men", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("69c1cdff-aac1-4231-a21a-42603603664f"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/bglc6y1504388797.jpg", "Blackberry brandy, Anis", "mix equal parts in pony glass-tastes just like a jelly bean!", "1 oz, 1 oz", "Jelly Bean", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a8bf28c7-0bb5-4f13-843d-6ee517f2a170"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/qvuyqw1441208955.jpg", "151 proof rum, Pina colada mix, Daiquiri mix", "First: Mix pina colada with 2.5 oz. of rum with ice(set aside). Second: Mix daiquiri with 2.5 oz. of rum with ice. Third: While frozen, add pina colda mix then daiquiri mix in glass (Making sure they do not get mixed together).", "5 oz Bacardi, frozen, frozen", "Miami Vice", "IBA" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("14cd205f-2968-4e75-bf57-bc64ea287272"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vqyxqx1472669095.jpg", "Gin, 7-Up, Lemon juice", "Pour 2 oz. gin. Add 4 oz. 7-up. Add Lemon Juice for flavor. If you are weak, top up glass with more 7-Up.", "2 oz dry, 4 oz, 0.75 oz", "69 Special", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("89d551f5-f520-47e0-bdee-c1b436e3a4a0"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/sywsqw1439906999.jpg", "Irish whiskey, Coffee, Sugar, Whipped cream", "Heat the coffee, whiskey and sugar; do not boil. Pour into glass and top with cream; serve hot.", "1 1/2 oz, 8 oz, 1 tsp, 1 tblsp", "Irish Coffee", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("0f439810-cba2-43b9-87d8-da6167c284ac"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/qyyvtu1468878544.jpg", "Creme de Cacao, Vodka", "1. Fill a rocks glass with ice 2.add white creme de cacao and vodka 3.stir", "1 oz white, 1 oz", "'57 Chevy with a White License Plate", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("00293361-b5bf-4b2b-9013-20fdb75ca12b"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/7stuuh1504885399.jpg", "Goldschlager, Butterscotch schnapps, Milk", "Shake over ice, strain. Serves two.", "1 oz, 1 oz, 1 oz", "Mother's Milk", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("8babac11-0f10-4b62-9183-d76fb122da97"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/1sqm7n1485620312.jpg", "Amaretto, Rum, Kool-Aid", "Mix Kool-Aid to taste then add Rum and ammaretto. shake well to disolve the sugar in the Kool-Aid... serve cold", "2 oz, 2 oz, 4 oz Grape", "Zippy's Revenge", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("3d8e908a-d756-4259-9155-a6b62c5bcc85"), null, "Soft Drink / Soda", "https://www.thecocktaildb.com/images/media/drink/rttsxw1441245419.jpg", "Vodka, Coconut liqueur, Blue Curacao, Sprite", "Just pour all ingredients in the glass and stir...", "2 cl, 1 cl, 1 cl, Fill with", "Belgian Blue", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("89fd014f-d960-4f40-9bdd-1162112032c2"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/rhhwmp1493067619.jpg", "Absolut Vodka, Gin, Tonic water", "Pour Vodka and Gin over ice, add Tonic and Stir", "1 oz, 1 oz, 4 oz", "AT&T", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c9dff132-a88d-485f-83f6-15b5ca3a3be7"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/7p607y1504735343.jpg", "Crown Royal, Amaretto, Cranberry juice", "One shot each, shake n shoot", "1 shot, 1 shot, 1 shot", "Red Snapper", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("2e272156-8352-4d90-99af-3a44c611e71e"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/ck6d0p1504388696.jpg", "Dark rum, Lime, Coca-Cola, Ice", "Fill tall glass with ice cubes. Add rum. Rub cut edge of lime on rim of glass then squeeze juice into glass. Fill with Coca-Cola. Garnish with lime slice. Enjoy!", "1-2 shot, Squeeze, Fill with", "Cuba Libra", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("50533ab9-646c-4865-b43d-5feba8c5be3b"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/09yd5f1493069852.jpg", "7-Up, Apple schnapps", "pour into a shot glass and present to consumer, they are expected to cover the top of the shotglass with thier palm, raise the glass, slam it on the bar and the swallow quickly.", "1 part, 1 part", "Apple Slammer", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("94a88a4d-1a14-463d-8d4b-ecca015b8398"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/7rfuks1504371562.jpg", "Vodka, Cranberry juice, Grapefruit juice", "Build all ingredients in a highball glass filled with ice. Garnish with lime wedge.", "1 1/2 oz, 4 oz, 1 oz", "Sea breeze", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("974d79b0-d332-4a43-9005-ebf5c4dd4f1f"), null, "Beer", "https://www.thecocktaildb.com/images/media/drink/xuwpyu1441248734.jpg", "Lager, Cider", "Pour ingredients into a pint glass. Drink. Fall over.", "1/2 pint, 1/2 pint sweet or dry", "Snake Bite (UK)", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a2853939-458d-41e3-a0f4-a63f3ecc9183"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/rrqrst1477140664.jpg", "Midori melon liqueur, J�germeister, Goldschlager", "Layer in a 2 oz shot glass or pony glass", "1/2 oz, 1/2 oz, 1/2 oz", "Bob Marley", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c551f3f2-00aa-4e6f-b4d4-7d22404f17c3"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/ruywtq1461866066.jpg", "Sambuca, Erin Cream, Advocaat", "layered erin first, then sambuca and then avocart(should sit in middle of other two. To drink: use a straw to suck up avocart then shot the rest and then suck fumes up through straw.", "30 ml white, 30 ml, 5 ml", "Brainteaser", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("24a8b1ec-fede-4a98-a5be-7bb6a5e8e932"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/doyxqb1493067556.jpg", "Vodka, Southern Comfort, Passion fruit syrup, Sweet and sour, Club soda", "Shake all the ingredients, top the drink with soda. Garnish with a slice of orange.", "2 cl Smirnoff, 2 cl, 2 cl, 6 cl, 1 dash", "Atlantic Sun", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("e628c20f-b106-41e5-81cb-f875ec03c9b3"), null, "Beer", "https://www.thecocktaildb.com/images/media/drink/qxprxr1454511520.jpg", "Cider, Lager, Blue Curacao", "Cider First, Lager then Curacao", "1/2 pint hard, 1/2 pint, 1 shot", "Green Goblin", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("6dfb70b0-e96d-4552-a82c-2be11e5c174b"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/xnzc541493070211.jpg", "Amaretto, Sour mix", "Shake and strain. Garnish with a cherry and an orange slice.", "1 1/2 oz, 3 oz", "Amaretto Sour", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f0b5c0aa-f9f4-4517-8f5e-0ce5b7039782"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/tpwwut1468925017.jpg", "Vodka, Kahlua, Baileys irish cream, Vanilla ice-cream, Oreo cookie", "Blend Vodka, Kahlua, Bailey's, ice-cream and the Oreo well in a blender. Pour into a large frosted glass. Garnish with whipped cream and a cherry.", "1 oz, 1 oz, 1 oz, 2 scoops, 1", "Oreo Mudslide", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("dcba126a-11cb-436f-b7b8-4f67cef3a2b1"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/squsuy1468926657.jpg", "Sprite, Pink lemonade, Vodka", "Shake well", "1 L, 2 cups, 2 cups", "Pink Panty Pulldowns", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("118b8703-0382-4f13-a240-90a8775de376"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/ypsrqp1469091726.jpg", "Vodka, Iced tea, Lemon juice", "Put Vodka in glass fill with iced tea. Stir in lemon to taste.", "1 1/2 oz, 6 oz, to taste", "Ice Pick #1", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7768e733-c0a1-4c6e-8122-977d1d838fbf"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/xtuyqv1472669026.jpg", "Peach Vodka, Coca-Cola", "", "2-3 oz", "410 Gone", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a1c3b6a1-d662-42ae-afe4-76d49bc37d7e"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/quqyqp1480879103.jpg", "Tequila, Orange juice, Grenadine", "Pour the tequila and orange juice into glass over ice. Add the grenadine, which will sink to the bottom. Stir gently to create the sunrise effect. Garnish and serve.", "2 measures", "Tequila Sunrise", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7832654e-2308-4f4a-bab7-2b9ac75c7a88"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/x894cs1504388670.jpg", "Vodka, Baileys irish cream, Kahlua", "Pour first vodka, then Bailey's, then Kahlua into a cocktail glass over crushed ice. Stir. Caution: use only high quality vodka. Cheap vodka can cause the Bailey's to curdle. Test your brand of vodka by mixing 1 Tsp each of vodka and Bailey's first.", "1 oz, 1 1/2 oz, 1/2 oz", "Screaming Orgasm", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("27c18325-900f-4e92-b58a-8ec46562973c"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/sqvqrx1461866705.jpg", "Sambuca, Sarsaparilla", "Bang 'em both in.", "1/4 glass, 3/4 glass", "Flander's Flake-Out", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("2cc0fbe5-569b-4d34-9b53-0b79762fd1f8"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/tqpvqp1472668328.jpg", "Amaretto, Baileys irish cream, Cognac", "Layered in a shot glass.", "1/3, 1/3, 1/3", "ABC", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7b7d3a63-a8cf-4daf-ba5a-8b45a7b4c589"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/ttsvwy1472668781.jpg", "Vodka, Grape soda, Orange juice, Ice, Candy", "Fill glass with ice and fish, add vodka, grape soda and orange juice. DO NOT STIR!!!!! Serve well chilled.", "1/3 part, 1/3 part, 1/3 part, lots, 1 dash", "Arctic Fish", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("209f077c-3bc8-4f67-b0bd-34cc8745b228"), null, "Milk / Float / Shake", "https://www.thecocktaildb.com/images/media/drink/urpvvv1441249549.jpg", "Coffee liqueur, Light rum, Ice, Milk", "Fill a tumbler with ice cubes. Add a shot of Tia Maria and a shot of Jamaican light rum. Fill the tumbler with milk. Blend until smooth and serve immediately.", "1 shot, 1 shot Jamaican, cubes", "Jamaica Kiss", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("dcd90076-1d6c-4d67-adaa-26ed4fe8de17"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/upxxpq1439907580.jpg", "Cointreau, Vodka, Lime, Cranberry juice", "Pour all ingredients in mixing glass half filled with ice, shake and strain into chilled Martini glass.", "1/2 oz, 1 oz, Juice of 1/2, 1 splash", "Cosmopolitan Martini", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a1f9cba3-a9a1-4ecd-b97d-884e3d4d12e0"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/vtyqrt1461866508.jpg", "Kahlua, Sambuca, Baileys irish cream", "This is a layered shot - the Bailey's must be on top", "", "Dirty Nipple", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4de24944-abd3-414e-9cfb-d81b460aa7b9"), null, "Soft Drink / Soda", "https://www.thecocktaildb.com/images/media/drink/sxxsyq1472719303.jpg", "Cherry Heering, Soda water, Orange juice, Ice", "There are many good cherry liqueurs you can use, but I prefere Heering. Add one share of the liqueur. Then you add one share of Soda. For a sour sling use Tonic (most people prefer the drink without Tonic). Afterwards you fill the glass with Orange Juice and ice cubes.", "1 part, 1 part, 1 part, cubes", "Darkwood Sling", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("324f6990-dc4c-43e4-b7f4-7564a1a7d432"), null, "Soft Drink / Soda", "https://www.thecocktaildb.com/images/media/drink/qxrvqw1472718959.jpg", "Baileys irish cream, Vanilla ice-cream, Cream", "Blend ingredients for 30 seconds. Definitely refreshing for a hot summer's day !", "2 oz, 2 scoops", "Bailey's Dream Shake", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("fbd0dd79-0a2a-4720-b51e-776dde892908"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/uwqpvv1461866378.jpg", "Baileys irish cream, Kahlua, Sambuca", "This is a layered shot. First pour the Bailey's into the shot glass. Then take an upside down spoon and touch it to the inside wall of the glass. Carefully add the Kahlua. Repeat this process for the Sambuca. If done properly, the alcohol will stay separated and resemble a bumble bee. Enjoy!!!", "1/3 oz, 1/3 oz, 1/3 oz", "Bumble Bee #1", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5b40ffe0-74a9-4460-a833-5a5eb7d11eaa"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/ruxuvp1472669600.jpg", "White Creme de Menthe, Southern Comfort, Vodka, Hot chocolate", "shake vigorously", "1/2 oz, 3/4 oz, 1/2 oz, Fill with", "A.D.M. (After Dinner Mint)", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("195c6df2-f2f5-48ac-a3ce-ce15e824e388"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/rsvtrr1472668201.jpg", "Cranberry juice, Soda water, Midori melon liqueur, Creme de Banane", "Drop shot glass with banana & melon liquers into a 9 oz hi- ball glass containing soda water and cranberry juice. Drink in one shot.", "2 oz, 2 oz, 0.5 oz, 0.5 oz", "A Splash of Nash", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("2e22c8b6-880b-4383-8336-d21afae1626b"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/xrsrpr1441247464.jpg", "Absolut Kurant, Tea, Sugar", "Pour Absolut Kurant into a comfortably big tea-cup. Add the not too hot(!) apple tea and, if you like, some sugar. Enjoy!", "4 cl, Turkish apple, (if needed)", "Kurant Tea", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("25ce7d33-ec99-47ad-befa-4280178c3ce2"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/akcpsh1493070267.jpg", "Amaretto, Orange juice, Grenadine", "Mix together the amaretto and orange juice. Pour into glass and then add the grenadine untill you see the sunrise.", "1 cl, 4 oz, 1/4 cl", "Amaretto Sunrise", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("070022c7-57c5-4e18-9311-2532f50bf289"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/mgf0y91503565781.jpg", "Spiced rum, Grenadine, Orange juice, Sour mix", "Combine liquors in a blender. Add a half scoop of ice and blend. Garnish with an orange and cherry flag. So good it will melt in your mouth!!!", "1.5 oz, 0.5 oz, 4 oz, 1 splash", "Orange Push-up", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4636832b-bf5b-4119-bf19-8f9505b94021"), null, "Milk / Float / Shake", "https://www.thecocktaildb.com/images/media/drink/rvwrvv1468877323.jpg", "Malibu rum, Light rum, 151 proof rum, Dark Creme de Cacao, Cointreau, Milk, Coconut liqueur, Vanilla ice-cream", "Combine all ingredients. Blend until smooth. Garnish with chocolate shavings if desired.", "1/2 oz, 1/2 oz, 1/2 oz Bacardi, 1 oz, 1 oz, 3 oz, 1 oz, 1 cup", "151 Florida Bushwacker", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("19143408-90bf-4a36-bab7-9920fa02bbbc"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/0fbo2t1485620752.jpg", "Cointreau, Lemon juice, Ice, Lemon", "Pour 5cl of Cointreau on ice, add 2cl of fresh lemon (or lime) juice, stir gently, and finally add slices of lemon/lime in glass.", "5 cl, 2 cl, cubes, or lime", "Zizi Coin-coin", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7fad5001-7ce9-47e9-a511-294a89f4f82c"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/vqws6t1504888857.jpg", "Malibu rum, Blackberry brandy, Orange juice, Pineapple juice, Cranberry juice", "Mix all ingredients in glass & add ice.", "1 1/2 oz, 1 oz, 3-4 oz, 3-4 oz, 3-4 oz", "Rum Runner", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4a84b485-4d53-464b-a137-941a2715f2b2"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/8189p51504735581.jpg", "Tequila, Tabasco sauce", "Fill shot glass with Tequila. Add drops of Tobasco sauce.", "full glass, About 8 drops", "Tequila Surprise", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("026ebced-498d-46e2-b007-60f589eb7677"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/yqstxr1479209367.jpg", "Spiced rum, Ginger ale", "Pour 1oz of Spiced Rum into a highball glass with ice. Fill with Ginger Ale.", "1 oz", "Cream Soda", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("0d7524d6-2f75-49f5-9833-feedd8b24ffb"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/y7w0721493068255.jpg", "Absolut Vodka, Iced tea", "Place ice cubes in the hurricane glass . Add the 2 HEAPING shots of Absolute Vodka (Note: You can add as many shots of Absolute as you want!) Fill the rest of glass with the Arizona Icetea with lemon. Stir to mix using a spoon. Drink up and enjoy!!!!!!!", "2 shots, 12 oz lemon", "Arizona Stingers", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("85a693fc-9d17-4a10-9e9b-1a635000e8f2"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/trpxxs1472669662.jpg", "Absolut Citron, Sweet and sour, Sprite, Soda water, Lemon", "Add all ingredients except lemon to shaker filled with ice. Cover and shake vigorously. Strain contents into ice filled collins glass. Garnish with lemon.", "1 1/2 oz, 3/4 oz, 1/2 oz, 3 oz, 1 slice", "Absolut Summertime", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("bd16583f-ee9f-4d20-99f5-1bc2f0d6ec5d"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/kugu2m1504735473.jpg", "Kool-Aid, Vodka", "Fill half the shot glass with the kool-aid first. Then put a paper towel over the top of the glass and slowly pour in the vodka. If you do it right, you should be able to see that the two liquids are separated, with the vodka on top. Now slam it! The last thing you'll taste is the kool-aid.", "1/2 oz Grape, 1/2 oz", "Kool-Aid Slammer", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d8dca04d-fe5e-4e07-b9df-53e066f8e29f"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/wrxrxp1472812609.jpg", "Absolut Citron, Pisang Ambon, Ice, Bitter lemon", "Mix, pour over ice and top up with Bitter Lemon.", "2/3 part, 1/3 part, cubes", "Absolut Evergreen", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("0edcef5c-4cd8-45af-ba09-e30ed2d1413f"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/xnzr2p1485619687.jpg", "Vermouth, Apple juice", "Serve without ice. At least the juice shold have room temperature.", "4 cl, 16 cl", "Ziemes Martini Apfelsaft", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("49b4524f-116a-4c85-b5a6-7a31519f3444"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/qyxrqw1439906528.jpg", "Vodka, Dry Vermouth, Olive", "Shake the vodka and vermouth together with a number of ice cubes, strain into a cocktail glass, add the olive and serve.", "1 1/2 oz, 3/4 oz, 1", "Vodka Martini", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("522e63a7-d2af-49a1-ad36-ae10c1eb2f44"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/vqwptt1441247711.jpg", "Coffee, Milk, Triple sec, Brandy", "Fill mug almost to top with coffee.Add milk, triple sec and brandy. Stir.", "1/2 oz, 1/2 oz", "Cafe Savoy", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("fe6a77c3-800f-4fed-b6f7-048e81fb89c9"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/7ibfs61504735416.jpg", "Advocaat, Lemonade, Lemon, Ice", "Place one ice cube in the glass and add 1 1/2 oz of Advocaat. Fill up the glass with lemonade and decorate with a slice of lemon. Serve at once.", "1 1/2 oz, 8-10 oz cold, 1 slice, cubes", "Snowball", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a1fece3c-86c1-410c-bc00-97bf3947df50"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/vtwyyx1441246448.jpg", "Coffee, Chambord raspberry liqueur, Cocoa powder, Whipped cream", "pour 6 oz. of coffee in a mug or Irish coffee cup. add coca mix and chambord, mix well and top off with whipped cream.", "6 oz, 2 oz, 2 tblsp", "Mocha-Berry", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c7383368-d0f8-49c7-82c5-d448b9041b54"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/xxsxqy1472668106.jpg", "Kahlua, Baileys irish cream, Frangelico", "pour kaluha, then Baileys, then Frangelico not chilled and not layered -- SERVE!!!", "1/3 part, 1/3 part, 1/3 part", "747", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("ccc76f4b-eddc-4a15-b1a2-09408c793d5d"), null, "Beer", "https://www.thecocktaildb.com/images/media/drink/qywpvt1454512546.jpg", "Beer, Amaretto, Orange juice", "Fill a pint glass almost full with beer. Then fill the rest with orange juice (careful not to fill it to the top). Then take the shot of Amaretto and drop it in.", "3/4 bottle, 1 shot, 1 oz", "Lunch Box", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("ae4da58d-c790-407d-bbcc-19ad36ae6a10"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/4vo5651493068493.jpg", "Vodka, Grenadine, Orange juice", "Combine ingredients in the order listed into a shaker. Fill half full with ice and shake well. Strain into glass with ice and garnish with a cherry and orange wedge.", "1 shot, 1 tblsp, Fill with", "Addison Special", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("ac825ede-e2af-4bab-9c3d-5d9b5e3a7b8d"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/xwryyx1472719921.jpg", "Amaretto, Sour mix, Orange juice", "Shake and Serve over ice", "1 part, 1 part, 1 part", "Amaretto Stone Sour", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("3c3531ff-9af3-45cf-8f5b-d69c9e285c01"), null, "Milk / Float / Shake", "https://www.thecocktaildb.com/images/media/drink/wxuqvr1472720408.jpg", "Baileys irish cream, Godiva liqueur, Kahlua, Butterscotch schnapps, Milk", "Fill glass with ice. Add all liquers. Add milk. shake.", "3/4 oz, 3/4 oz, 3/4 oz, 1/2 oz, to fill", "Blind Russian", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("e571d76c-7678-4a44-9bb4-30d8c058b1a4"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/xtrvtx1472668436.jpg", "Absolut Kurant, Midori melon liqueur, Cranberry juice, Sprite", "Shake Absolut Kurant, Midori, and Cranberry juice in shaker with ice: Strain into rocks glass: Splash of seven on top.Absolut Sex.", "3/4 oz, 3/4 oz, 1 oz, 1 splash", "Absolut Sex", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f2ca61b5-aa93-444c-9c65-b72f59cf8d6c"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/uqwuyp1454514591.jpg", "Lemonade, Vodka, Rum, Ginger ale", "Mix all ingredients in a pitcher. Mix thoroughly and pour into whatever is available, the bigger the better! This drink packs a big punch, so don't over do it.", "1 can, 5 oz, 7 oz, About 1 bottle", "Aztec Punch", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f521b784-80de-4d29-9173-37f488b7ab39"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/mtpxgk1504373297.jpg", "Absolut Vodka, Cointreau, Lemon", "Shake and strain into a chilled cocktail glass rimmed with sugar.", "1 1/2 shot, 1 1/2 shot, Juice of 1 wedge", "Lemon Drop", "IBA,NewEra" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("fc39de36-757a-449b-bb56-ca4b107ef84e"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/ssqpyw1472719844.jpg", "Absolut Citron, Lime juice, Ice, Tonic water", "Fill Absolut into a glass. Add Lime juice. Add Ice and lime wedges.", "2/3, 1/3, Fill with, Top it up with", "Absolut limousine", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("9c2aa86c-5e8b-42b8-a964-925d1dd1f7a5"), null, "Soft Drink / Soda", "https://www.thecocktaildb.com/images/media/drink/rsxuyr1472719526.jpg", "Kahlua, Galliano, Soda water", "Put Kahlua and Galliano in highball glass fill with soda", "3/4 oz, 3/4 oz, Fill with", "California Root Beer", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("9d01bbc7-0352-4f28-9d5a-c036e6ffe1c5"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/upusyu1472667977.jpg", "Whisky, Baileys irish cream, Coffee", "Mix the whisky and Baileys Cream in a beer-glass (at least 50 cl). Fill the rest of the glass with coffee.", "4 cl, 8 cl", "H.D.", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5b35d76b-ed79-4d60-94c7-23bdd0129958"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/sutyqp1479209062.jpg", "Jack Daniels, Midori melon liqueur, Sour mix", "Add all ingredients into mixing glass, chill and strain into cocktail glass", "1 oz, 1/2 oz, 2 oz", "Applejack", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4cb9068b-2c21-4813-a219-7cf22ee981a5"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/uv96zr1504793256.jpg", "Lemonade, Water, Vodka", "Mix lemonade and water according to instructions on back of can. If the instructions say to add 4 1/3 cans of water do so. Mix into pitcher. Add 1 1/2 cup of Vodka (Absolut). Mix well. Pour into glass of crushed ice. Excellent!", "1 can, 3 cans, 1 1/2 cup", "Shark Attack", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b62ec5bd-6e3f-43f2-8c3b-ff45e703788b"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/yfhn371504374246.jpg", "Tequila, Tomato Juice, Orange Juice, Lime Juice, Sugar Syrup, Salt", "Vampiros may be made in a tall glass or an old fashioned glass. Bartenders may first \"rim\" the glass with Kosher Salt, which is done by placing a layer of Kosher Salt on a chopping board, moistening the glass' rim with lime juice or water, and then placing the upside down glass rim onto the Kosher Salt, so that the salt sticks to the moistened rim. The second step is to fill half the glass with ice and add one or two shooter glasses full of high quality Tequila. The next stage is to add the flavouring elements. This is done by squeezing a fresh lime into the glass, adding a few grains of salt, adding citrus-flavoured soda pop, until the glass is 4/5 full, and then adding spicy Viuda de Sanchez (or orange juice, lime juice and pico de gallo). The final step is to stir the ingredients so that the flavours are properly blended.", "6 cl, 3 cl, 3 cl, 1.5 cl, 1 dash, 1 pinch", "Vampiro", "IBA,NewEra" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("76fc1290-0cc2-4c73-8890-e6240711362b"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/mtdxpa1504374514.jpg", "Gin, Vodka, Lillet Blanc", "Shake over ice until well chilled, then strain into a deep goblet and garnish with a thin slice of lemon peel.", "6 cl, 1.5 cl, 0.75 cl", "Vesper", "IBA,NewEra" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5856ab6b-de20-4f09-aba7-15b935ed450a"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/2t9r6w1504374811.jpg", "White Rum, Galliano, Triple Sec, Lime Juice", "Shake and strain into a chilled cocktail glass", "3 cl, 1.5 cl, 1.5 cl, 1.5 cl", "Yellow Bird", "IBA,NewEra" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("05fb816d-0a98-41ab-92f0-bfe4da6f7fe4"), null, "Milk / Float / Shake", "https://www.thecocktaildb.com/images/media/drink/1xhjk91504783763.jpg", "Vanilla Ice-Cream, Butterscotch schnapps, Milk, Vodka", "Blend together in a blender. Serve in a chilled Beer mug with Fresh Blueberries and caramel for topping.", "2 scoops, 1 part, full glass, 2 parts", "Butter Baby", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("6e10bf29-fbba-418b-b687-2d3e23f9d8ba"), null, "Milk / Float / Shake", "https://www.thecocktaildb.com/images/media/drink/861tzm1504784164.jpg", "Vanilla Ice-Cream, Milk, Godiva liqueur, Whipped Cream, caramel sauce, chocolate sauce, Mini-snickers bars", "Place the snickers bars in a plastic bag and roll over them with a rolling pin until crushed. Add crushed snickers pieces, ice cream, milk, caramel sauce, chocolate sauce, and chocolate liquor to a blender. Blend until shake is thick and frothy. Pour into glasses and top with chocolate liquor and whip cream.", "3 cups, 1 cup, 1/2 cup, for topping, 4 tablespoons, 4 tablespoons, 15", "Boozy Snickers Milkshake", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("df291d15-b2e6-4cda-9119-c22b6da26718"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/2x8thr1504816928.jpg", "Gin, Grand Marnier, Lemon Juice, Grenadine", "Pour all ingredients into a cocktail shaker, mix and serve over ice into a chilled glass.", "1 3/4 shot, 1 Shot, 1/4 Shot, 1/8 Shot", "A1", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d7216371-f41b-44f4-b03d-b5d5a4056085"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/loezxn1504373874.jpg", "Tequila, Lime Juice, Agave syrup", "Shake and strain into a chilled cocktail glass.", "4.5 cl, 1.5 cl, 2 spoons", "Tommy's Margarita", "IBA,NewEra" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5d3af0a5-c3ae-4f9a-95b8-e49a19c39654"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/2mcozt1504817403.jpg", "Gin, Sweet Vermouth, Orange Juice, Angostura Bitters", "Put all ingredients into a shaker and mix, then strain contents into a chilled cocktail glass.", "2 shots, 1 shot, 1 shot, 3 dashes", "Abbey Martini", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("61d740cd-6910-4817-b10c-b341261f1f05"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/l3cd7f1504818306.jpg", "Gin, Grenadine, Heavy cream, Milk, Egg White", "Shake all the ingredients in a cocktail shaker and ice then strain in a cold glass.", "2 shots, 1/2 shot, 1/2 shot, 1/2 shot, 1/2 Fresh", "Ace", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4e11332e-e623-4f37-b735-890d5dede098"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/vfeumw1504819077.jpg", "Gin, Cognac, Creme de Cassis, Fresh Lemon Juice", "Shake together all the ingredients and strain into a cold glass.", "1 shot, 1 shot, 1 shot, 1/8 shot", "Adam & Eve", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b021357c-6a5f-4406-ac4b-8d2efeac0ed9"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/ib0b7g1504818925.jpg", "Sweet Vermouth, Dry Vermouth, Soda Water", "Mix both the vermouth's in a shaker and strain into a cold glass. Top up with a squirt of Soda Water. ", "2 shots, 1 shot, Top up with", "Addington", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("85599552-b7e6-46a4-b122-c14756ebbe5b"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/yzva7x1504820300.jpg", "Gin, Vermouth", "Shake together all the ingredients and strain into a cold glass.", "1 1/2 shot, 1 1/2 shot", "Addison", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b7679337-8614-4227-b505-45bf64ff81c0"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/8nk2mp1504819893.jpg", "Rum, Dry Vermouth, Cognac, Gin, Fresh Lime Juice, Sugar Syrup, Water", "Shake together all the ingredients and strain into a cold glass.", "1 shot, 1/2 shot, 1/2 shot, 1/2 shot, 1/4 shot, 1/4 shot, 1/2 shot", "Adios Amigos Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("9abeadb7-d217-4046-9834-86b7451db58a"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/s00d6f1504883945.jpg", "Gin, Grenadine, lemon, Soda Water, Lime", "Half-fill a tall glass with ice. Mix the gin and Grenadine together and pour over the ice. Add the lime or lemon juice and top off with soda water. Decorate the glass with lime and/or lemon slices.", "2 oz, 1 tsp, Juice of 1/2, Top up with, Garnish", "Gin Rickey", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f917b9a7-ced9-4159-bc48-c1531cc3cd9c"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/abcpwr1504817734.jpg", "Vodka, Cranberry Juice, Champagne", "Mix the Vodka and Cranberry juice together in a shaker and strain into a glass. Top up with Champagne.", "1 shot, 2 shots, Top up with", "Absolutely Fabulous", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("1decd3a0-316e-4115-983e-8db9794069ba"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/3s6mlr1509551211.jpg", "Gin, Chocolate liqueur, Amaretto, Chocolate Sauce, Salted Chocolate", "Add ice, toffee gin, chocolate liqueur and Amaretto to a cocktail shaker and shake vigorously. \r\nPour the chocolate syrup into a saucer and dip the top of a martini glass into the sauce. Grate some of the Willie\\'s sea salt chocolate into another saucer and dip the coated glass, so the flakes stick to the sauce, creating a chocolate rim!\r\nPour the contents of the shaker into your chocolatey glass and sprinkle with more grated chocolate - enjoy!  ", "50 ml, 30 ml, 15 ml, Garnish, Grated", "Salted Toffee Martini", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("0ca8c2ec-7f42-44cb-afd9-f9e75a13dc41"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/j9evx11504373665.jpg", "Prosecco, Campari, Soda Water", "Build into glass over ice, garnish and serve.", "6 cl, 4 cl, splash", "Spritz", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("52487f17-ea2a-4b4d-9571-23ef84f39bcc"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/clth721504373134.jpg", "Vodka, Raspberry Liqueur, pineapple juice", "Pour all ingredients into shaker with ice cubes. Shake well and strain into a chilled cocktail glass. Squeeze oil from lemon peel onto the drink.", "4.5 cl, 1.5 cl, 1.5 cl", "French Martini", "NewEra,IBA" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c5adbe66-59f9-4447-b55f-af96f3722114"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/qrot6j1504369425.jpg", "Galliano, Triple Sec, orange juice, Cream", "Shake with cracked ice. Strain into glass and serve.", "2 parts, 2 parts, 2 parts, 1 part", "Golden dream", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("aaee6d52-6507-49bf-9450-d82b41d8f331"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/aqm9el1504369613.jpg", "Green Creme de Menthe, Creme de Cacao, Light cream", "Pour ingredients into a cocktail shaker with ice. Shake briskly and then strain into a chilled cocktail glass.", "3/4 oz, 3/4 oz white, 3/4 oz", "Grasshopper", "IBA,ContemporaryClassic,Halloween" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f13db4bc-cf57-4eaa-9a8e-737db3b749fd"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/jfcvps1504369888.jpg", "Rum, Grapefruit Juice, Maraschino Liqueur, Lime Juice", "Pour all ingredients into a shaker with ice. Shake.", "12 parts, 8 parts, 3 parts, 3 parts", "Hemingway Special", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("dfe56f44-a4e9-4b69-abe1-f46e4b979e0f"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/006k4e1504370092.jpg", "Lemon peel, Brandy, Ginger ale, Bitters", "Pour brandy and ginger ale directly into highball glass with ice cubes. Stir gently. Garnish with lemon zest. If desired, add dashes of Angostura Bitter.", "1 long strip, 2 oz, 5 oz, 2 dashes", "Horse's Neck", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5c35a8bd-ce5d-48bd-a06d-3d2491e43b46"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/apneom1504370294.jpg", "Creme de Cassis, Champagne", "Add the cr�me de cassis to the bottom of the glass, then top up with wine.", "1 part, 5 parts", "Kir", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d40c4d37-1a45-475e-91b3-198cd6a70aa6"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/wx7hsg1504370510.jpg", "Vodka, Tequila, Light rum, Gin, Coca-Cola, Lemon peel", "Mix all contents in a highball glass and sitr gently. Add dash of Coca-Cola for the coloring and garnish with lemon or lime twist.", "1/2 oz, 1/2 oz, 1/2 oz, 1/2 oz, 1 dash, Twist of", "Long Island Iced Tea", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b7553c02-9094-4991-b383-32bbd14ff654"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/ctt20s1504373488.jpg", "Vodka, Creme de Cassis, Sugar Syrup, Lemon Juice", "Pour the ingredients into an highball glass, top with Sparkling wine.", "2.5 cl, 1.5 cl, 1 cl, 2.5 cl", "Russian Spring Punch", "IBA,NewEra" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("6fa39da3-3e38-46a3-bb99-c11fa15a1f92"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/juhcuu1504370685.jpg", "Champagne, Orange juice", "Ensure both ingredients are well chilled, then mix into the glass. Serve cold.", "Chilled, 2 oz", "Mimosa", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5ba14c01-e20e-4604-abfd-82ca17696961"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/cpf4j51504371346.jpg", "Light rum, Coconut milk, Pineapple", "Mix with crushed ice in blender until smooth. Pour into chilled glass, garnish and serve.", "3 oz, 3 tblsp, 3 tblsp", "Pina Colada", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("6dcfb6ae-c630-4759-9ecd-0fd2d2abfa6e"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/8kxbvq1504371462.jpg", "Dry Vermouth, Gin, Apricot brandy, Lemon juice, Grenadine, Powdered sugar", "Shake together in a cocktail shaker, then strain into chilled glass. Garnish and serve.", "1/2 oz, 1 oz, 1/2 oz, 1/2 tsp, 1 tsp", "Rose", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("8e07b46b-487f-4b3a-b634-f3af37ad836f"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/jwmr1x1504372337.jpg", "Rum, Galliano, Pineapple Juice, Lime Juice, Prosecco", "Shake pour ingredients with ice. Strain into glass, top with Sparkling wine.", "4.5 cl, 1.5 cl, 6 cl, 1 dash, top up", "Barracuda", "IBA,NewEra" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("9069a7a1-70c5-48d6-b9e1-5c32501a6edd"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/lvzl3r1504372526.jpg", "Gin, lemon juice, Sugar syrup, Creme de Mure", "Fill glass with crushed ice. Build gin, lemon juice and simple syrup over. Stir, and then pour blackberry liqueur over in a circular fashion to create marbling effect. Garnish with two blackberries and lemon slice.", "4 cl, 1.5 cl, 1 cl, 1.5 cl", "Bramble", "IBA,NewEra" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("6a758054-7b2a-4f95-9b8a-c3bdd101f4a8"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/t1tn0s1504374905.jpg", "Dark Rum, Ginger Beer", "In a highball glass filled with ice add 6cl dark rum and top with ginger beer. Garnish with lime wedge.", "5 cl, 10 cl", "Dark and Stormy", "IBA,NewEra" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("315daab4-8d30-409a-9217-ded94974625f"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/n0sx531504372951.jpg", "Vodka, Kahlua, Sugar syrup", "Pour ingredients into shaker filled with ice, shake vigorously, and strain into chilled martini glass", "5 cl, 1 cl, 1 dash", "Espresso Martini", "IBA,NewEra" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("db754e10-42fc-4d1b-b44b-9f8f265e40d7"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/squyyq1439907312.jpg", "Mint, Bourbon, Powdered sugar, Water", "In a highball glass gently muddle the mint, sugar and water. Fill the glass with cracked ice, add Bourbon and stir well until the glass is well frosted. Garnish with a mint sprig.", "4 fresh, 2 1/2 oz, 1 tsp, 2 tsp", "Mint Julep", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("78ba45b9-5723-4631-9e06-adc71dbdec3b"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/zaqa381504368758.jpg", "Cognac, Amaretto", "Pour all ingredients directly into old fashioned glass filled with ice cubes. Stir gently.", "1 1/2 oz, 3/4 oz", "French Connection", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("22fa0d20-701e-48db-961e-c20da08178d1"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/t0iugg1509556712.jpg", "Vermouth, Maraschino Cherry, Sugar Syrup, Lemonade, Blackberries", "Put the Bombay Sapphire, Martini Bianco, sugar syrup & blackberries in a cocktail shaker with lots of ice and shake vigorously before pouring into a balloon glass, topping up with lemonade and garnishing with a wedge of orange.", "25 ml, 15 ml, 10 ml, 100 ml, 2", "Hunter's Moon", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("6ecfa685-c644-4ea6-beb9-eff7179806c2"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/h1e0e51510136907.jpg", "Gin, Creme de Cassis, Fresh Lime Juice, Ginger beer, Lime, Ginger", "Add the Bombay Sapphire, Cr�me de Cassis and lime juice to a balloon glass and swirl well to mix.\r\nFill the glass with good quality cubed ice.\r\nTop up with chilled and freshly opened Fever-Tree Ginger Beer.\r\nGently stir to combine, top with a gently squeezed lime wedge and finish with a fresh ginger slice.", "50 ml, 20 ml, 15 ml, 75 ml, 1, 1 long strip", "Bombay Cassis", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("e7d045e7-021a-4697-ad62-2db7826ce909"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/x03td31521761009.jpg", "Rye whiskey, Campari, Dry Vermouth", "Chill cocktail glass. Add ingredients to a mixing glass, and fill 2/3 full with ice. Stir about 20 seconds. Empty cocktail glass and strain into the glass. Garnish with a twist of lemon peel.", "2 oz, 1 oz, 1 oz", "Old Pal", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("38fa242c-f73f-43ec-a2ee-5a3cd57f203f"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/b522ek1521761610.jpg", "Irish Whiskey, Sweet Vermouth, Green Chartreuse", "Stir over ice. Strain into chilled glass. Cut a wide swath of orange peel, and express the orange oils over the drink. Discard orange twist.", "2 oz, 1 oz, 1/2 oz", "Tipperary", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("9cd09d57-bfd4-4951-8f00-c984a642c36d"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/hc9b1a1521853096.jpg", "Blended Scotch, Lemon Juice, Honey syrup, Ginger Syrup, Islay single malt Scotch", "Shake blended Scotch, lemon juice, honey syrup and ginger syrup with ice. Strain over large ice in chilled rocks glass. Float smoky Scotch on top (be sure to use a smoky Scotch such as an Islay single malt). Garnish with candied ginger.", "2 oz, 3/4 oz, 2 tsp, 2 tsp, 1/4 oz", "Penicillin", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("3be6b21f-b71a-4078-bc90-f47cd6841308"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/jfvyog1530108909.jpg", "Lime, Falernum, Angostura Bitters, A�ejo rum, blackstrap rum", "Cut the half lime in half again. Add the lime, falernum, and bitters to a rocks glass. Muddle. Add the rum. (Aged Barbados rum such as Plantation 5 Year is recommended). Add ice and stir. Float the blackstrap rum on top. Serve with a straw.", "1/2, 1/3 oz, 2 dashes, 1 oz, 1 oz", "Corn n Oil", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("44c8d7dd-267b-4434-b6c1-51bbe579f17f"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/ssxvww1472669166.jpg", "Light rum, Ginger beer, Lemon peel", "Pour the rum and ginger beer into a highball glass almost filled with ice cubes. Stir well. Garnish with the lemon twist.", "2 oz, 4 oz, 1 twist of", "A Furlong Too Late", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("9e79cc28-6744-4210-99a6-0c2f43c46801"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vyrvxt1461919380.jpg", "Light rum, A�ejo rum, Orange juice, Lemon juice, Ginger ale, Lemon peel", "In a shaker half-filled with ice cubes, combine the light rum, a�ejo rum, orange juice, and lemon juice. Shake well. Strain into a highball glass almost filled with ice cubes. Top with the ginger ale. Garnish with the lemon twist.", "1 oz, 1 oz, 1 oz, 1/2 oz, 3 oz, 1 twist of", "A Night In Old Mandalay", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("59ba9ba7-6199-4679-a917-ee206506fae7"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/wbcvyo1535794478.jpg", "Irish Whiskey, Amaretto, Cranberry Juice", "Fill glass with ice\r\nPour in The Irishman and Disaronno\r\nFill to the top with Cranberry Juice\r\nGarnish with a slice of lemon�Enjoy!", "50 ml, 50 ml, 4 oz", "The Jimmy Conway", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("46976ff6-3c61-4bfa-8db5-5c9a942e49fd"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/uryyrr1472811418.jpg", "Applejack, Grapefruit juice", "Shake ingredients with ice, strain into a cocktail glass, and serve.", "1 1/2 oz, 1 oz", "A. J.", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("013d3177-4b46-40e6-8231-f3f539cfc5e4"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/ysqwwt1461919465.jpg", "Dark rum, Peach nectar, Orange juice", "Pour all of the ingredients into a highball glass almost filled with ice cubes. Stir well.", "1 1/2 oz, 2 oz, 3 oz", "Abilene", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("27e76948-fb31-428a-8583-3b74753af332"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vtpsvr1472811976.jpg", "Light rum, Triple sec, Lime juice, Sugar, Egg white, Mint", "Combine and shake all ingredients (except mint) with ice and strain into an old-fashioned glass over ice cubes. Add the sprig of mint and serve.", "1 1/2 oz, 1 1/2 tsp, 1 tblsp, 1 tsp, 1, 1", "Acapulco", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c854c91a-49f0-48cb-aa62-a1c8b4525f21"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/rwuxsv1472812169.jpg", "Dark rum, Lemon juice, Grenadine", "In a shaker half-filled with ice cubes, combine all of the ingredients. Shake well. Strain into a cocktail glass.", "2 oz, 1 oz, 1 tsp", "Adam", "Alcoholic,Holiday" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("cd7d7c43-7d37-4158-9fdd-94b4c80232c2"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/xrvruq1472812030.jpg", "Sweet Vermouth, Sherry, Orange bitters", "Stir all ingredients with ice, strain contents into a cocktail glass, and serve.", "3/4 oz, 1 1/2 oz dry, 1 dash", "Adonis Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f57db95d-2a4a-4747-9eed-5e551ff18511"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/wxrsxx1472720734.jpg", "Strawberry schnapps, Orange juice, Cranberry juice, Club soda", "Pour schnapps, orange juice, and cranberry juice over ice in a highball glass. Top with club soda and serve.", "2 oz, 2 oz, 2 oz", "Affair", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b2b97363-7654-4a20-a2cf-c00bbe92d6af"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/nwatpb1504817045.jpg", "Scotch, Sweet Vermouth, Dry Vermouth, Orange bitters", "In a mixing glass half-filled with ice cubes, combine all of the ingredients. Stir well. Strain into a cocktail glass.", "1 1/2 oz, 1 oz, 1 oz, 2 dashes", "Affinity", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("1c78b5ca-31e1-4b0e-9b1d-175847142b46"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/quyyuw1472811568.jpg", "Gin, Orange bitters, Orange, Cherry", "Shake all ingredients (except for the cherry) with ice and strain into a cocktail glass. Top with the cherry and serve.", "1 1/2 oz, 1 dash, Juice of 1/4, 1", "Abbey Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("ffc5b620-4ba1-4000-bc4b-752a22a60d4e"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/2en3jk1509557725.jpg", "Rum, Gold rum, 151 proof rum, Pernod, Grenadine, Lime Juice, Angostura Bitters", "\r\nBlend at high speed for no more than 5 seconds.\r\n\r\nPour into a glass, add ice cubes to fill, then add the garnish.\r\n\r\n*Donn�s mix: Bring 3 crushed cinnamon sticks, 1 cup of sugar and 1 cup of water to a boil, stirring until the sugar is dissolved.\r\n\r\nSimmer for 2 minutes, then remove from the heat and let sit for at least 2 hours before straining into a clean glass bottle.\r\n\r\nThen add 1 part of the syrup and 2 parts of fresh grapefruit juice together.", "1 1/2 oz, 1 1/2 oz, 1 oz, 1 tsp, 1 tsp, 1 tsp, 1 drop", "Zombie", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("19e6da0f-bde7-44f8-841e-f5b74b8e9177"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/nl89tf1518947401.jpg", "Hot Chocolate, Green Chartreuse, Cherry Heering", "Mix ingredients in a warmed mug and stir.", "4 oz, 1 oz, 1 oz", "Brigadier", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("75588149-5209-4757-a9a0-646806eeb81f"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/nwx02s1515795822.jpg", "Rum, Dark Rum, Passoa, Blue Curacao, Sweet and Sour, Ice", "If each part is 1/2 oz then use about 2.5 cups of ice.\r\n\r\nBlend it all together. \r\nDrink it with a big straw if you have one.\r\n\r\n", "4 parts, 2 parts, 1 part, 1 part, 6 parts, cubes", "Blue Hurricane", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("def12233-615c-43d0-a7af-061c497f94c7"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/qwc5f91512406543.jpg", "Gin, Blue Curacao, Tonic Water, Rosemary", "1) Add the Bombay Sapphire, Blue Curacao, rosemary sprig and gently squeezed lemon wedge to a balloon glass. Swirl well to combine.\r\n2) Fill with cubed ice and top with the Fever-Tree Light Tonic Water.\r\n3) Gently fold with a bar spoon to mix.", "50 ml, 15 ml, 100 ml, Garnish with", "Rosemary Blue", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("10dda678-2a91-430b-b7a2-4be240a2d4a5"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/osgvxt1513595509.jpg", "Mezcal, Chocolate liqueur, Coffee liqueur", "To ensure that your pork fat is just as delicious as theirs, here�s their adobo marinade and what to do with it (you�ll also need a rack of ribs):\r\n\r\n4 ancho chiles, 8 guajillo chiles and 4 chipotle chiles, plus 4 cloves roasted garlic, half a cup of cider vinegar, a quarter teaspoon of Mexican oregano, 1 teaspoon of ground black pepper, a whole clove, a quarter teaspoon of ground cinnamon and a half teaspoon of ground cumin.\r\n\r\nToast the dried chiles and soak in water for at least an hour until they are rehydrated. Drain and discard the soaking liquid. Combine the soaked chiles with the remaining ingredients and pur�e until smooth.\r\n\r\nCold smoke a rack of baby back pork ribs by taking a large hotel pan with woodchips on one side and charcoal on the other. Place another, smaller, pan with pork ribs, above the charcoal/woodchip pan. Ignite the charcoal, being careful to not ignite the woodchips. Cover both pans with foil and allow to smoke for 10-15 minutes, until desired level of smoke is achieved, then coat with adobo marinade and wrap in tin foil prior to placing ribs in a 300 degree oven for 7 hours. When the ribs have cooled, strain off the fat and use for the infusion.\r\n\r\nIf you�re having a hard time coming up to the same kind of volume of fat, make up the balance with pork lard from a butcher. To get the same depth of flavor without the ribs, heat up the fat in a pot with a few spoons of the marinade.\r\n\r\nOnce you�ve got your tub of seasoned pork fat in cooled liquid form, pour equal amounts of Ilegal Joven mezcal and fat into a sealable container. Seal the container and give it a really good shake, then put it in the freezer overnight. When the whole thing is separated and congealed, pour it through a fine mesh chinoise. If you don�t have a chinoise, try a fine mesh strainer, or if you don�t have one of those, try spooning off most of the fat. There will be some beads of orange fat left in the strained mezcal: run that through a few layers of cheesecloth (or coffee filters in a pinch) to get rid of the last of it.\r\n\r\nThe mezcal is now ready for drinking, straight-up or in a cocktail. \r\n\r\nHabanero tincture\r\n\r\nSlice habaneros and add 2 ounces Ilegal Joven mezcal.\r\nAllow to sit overnight or until desired level of heat is achieved.\r\nCocktail\r\n\r\nCombine mezcal and chocolate liqueur in a mixing glass with ice and stir for 45 seconds.\r\nStrain into chilled coupe.\r\nCarefully \"sink\" the coffee liqueur down the inside of the coupe over a spoon.\r\nGarnish with 5 drops habanero tincture.", "2 oz, 3/4 oz, 1/2 oz", "Empell�n Cocina's Fat-Washed Mezcal", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("8bf491fb-0914-4b90-bf56-8f4e0a02e7d7"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/91oule1513702624.jpg", "Green Chartreuse, Maraschino Liqueur, Lime Juice", "Shake with ice and strain into a cocktail glass.", "1 oz, 1 oz, 1 oz", "The Last Word", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("055d7337-0da9-44e4-828c-02cd97763da0"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/x8lhp41513703167.jpg", "Gin, Lillet, Sweet Vermouth, Orange Peel", "Add ice to a shaker and pour in all ingredients.\nUsing a bar spoon, stir 40 to 45 revolutions or until thoroughly chilled.\nStrain into a martini glass or over ice into a rocks glass. Garnish with orange twist.", "1 oz, 1 oz, 1 oz, 1", "French Negroni", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("707699ac-1939-4dfe-9e22-8f4d49ecba31"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/jfkemm1513703902.jpg", "Gin, Orange Curacao, Lime Juice, Angostura Bitters, Orange Bitters", "Shake, strain, up, cocktail glass", "1 1/2 oz, 3/4 oz, 3/4 oz, 1 dash, 1 dash", "Pegu Club", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7fc96455-06cf-434e-889f-4a8af0bcabfd"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/gifgao1513704334.jpg", "Gin, Triple Sec, Lillet Blanc, Lemon Juice, Absinthe", "Shake, strain, straight up, cocktail glass rinsed with absinthe\r\n", "3/4 oz, 3/4 oz, 3/4 oz, 3/4 oz, 1 dash", "Corpse Reviver #2", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5dc203b2-3597-4193-8954-674bd905f632"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/6xfj5t1517748412.jpg", "Gin, Elderflower cordial, Rosso Vermouth, Tonic Water, Lime, Ginger, Mint", "1) Squeeze two lime wedges into a balloon glass then add the cordial, Bombay Sapphire and MARTINI Rosso Vermouth, swirl to mix.\r\n\r\n2) Fully fill the glass with cubed ice and stir to chill.\r\n\r\n3) Top with Fever-Tree Ginger Ale and gently stir again to combine.\r\n\r\n4) Garnish with a snapped ginger slice and an awoken mint sprig.", "50 ml, 15 ml, 15 ml, 75 ml, 2 Wedges, 1 Slice, 1 Large Sprig", "The Laverstoke", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("bc66ba9b-7a31-4fcc-a2d0-16a8620d4b02"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/km84qi1513705868.jpg", "Campari, Sweet Vermouth, Rye whiskey, Orange Peel", "Stir with ice, strain, garnish and serve.", "1 oz, 1 oz, 1 1/4 oz, 1", "Boulevardier", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d507b3f3-8b78-42de-aff1-7e2500e32027"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/samm5j1513706393.jpg", "Grape Soda, Tequila", "Stir together and serve over ice.", "3 oz, 1 1/2 oz", "Paloma", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c8d50828-5668-4a72-96fa-68393c836c1f"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/rysb3r1513706985.jpg", "Orange Bitters, Green Chartreuse, Gin, Sweet Vermouth", "Stir in mixing glass with ice and strain\r\n", "1 dash, 1 oz, 1 oz, 1 oz", "Bijou", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("0ac908cb-6ba9-4bb9-8ecc-7e0601ecb420"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/3xgldt1513707271.jpg", "Gin, Lime Juice, Sugar Syrup, Lime", "Add all the ingredients to a shaker and fill with ice.\r\n\r\nShake, and strain into a chilled cocktail glass or an Old Fashioned glass filled with fresh ice.\r\n\r\nGarnish with a lime wheel.", "2 1/2 oz, 1/2 oz, 1/2 oz, 1", "Gimlet", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d3342330-c488-4346-840a-5d378560f961"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/fs6kiq1513708455.jpg", "Gin, Sweet Vermouth, Maraschino Liqueur, Angostura Bitters", "Add all ingredients to a mixing glass and fill with ice.\r\n\r\nStir until chilled, and strain into a chilled coupe glass.", "1 1/2 oz, 1 1/2 oz, 1 tsp, 2 dashes", "Martinez 2", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f0d4a207-7e6c-4bcf-b314-80c7bf1d322b"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/bsvmlg1515792693.jpg", "Kahlua, Bailey, Butterscotch schnapps, Jagermeister, Goldschlager", "Just mix it all together.\r\nIt's meant to be a shot, but it works just fine as a proper adult-sized drink over lots of ice.\r\n\r\nTastes like an oatmeal cookie.", "2 parts, 2 parts, 4 parts, 1 part, 1/2 part", "Oatmeal Cookie", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("9a8caa87-74db-4a8b-b44b-3b877c27df88"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/tyb4a41515793339.jpg", "Rum, Dark Rum, Banana liqueur, Grenadine, Pineapple Juice, Orange Juice, Sweet and Sour", "Add 2 parts club soda or more or less to taste.\r\n\r\nMix it all together and pour over a bunch of ice. Drink with a straw.", "3 parts, 1 part, 1 part, 1 part, 2 parts, 2 parts, 1 part", "Bahama Mama", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("29a43dff-5c1d-4eca-8e45-1a646b79f461"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/g5upn41513706732.jpg", "Vodka, Grapefruit Juice", "Add the vodka to a Collins glass filled with ice.\nTop with grapefruit juice and stir.\n\n", "1 1/2 oz, 3 oz", "Greyhound", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b88d3093-42b6-447e-a79f-1f5dcc7a8951"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/4qnyty1504368615.jpg", "Gin, Sugar, Lemon juice, Champagne, Orange, Maraschino cherry", "Combine gin, sugar, and lemon juice in a cocktail shaker filled with ice. Shake vigorously and strain into a chilled champagne glass. Top up with Champagne. Stir gently.", "1 1/2 oz, 2 tsp superfine, 1 1/2 oz, 4 oz Chilled, 1, 1", "French 75", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("63acb326-472d-466c-a382-097ea4f70541"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/kpsajh1504368362.jpg", "Absolut Citron, Lime juice, Cointreau, Cranberry juice", "Add all ingredients into cocktail shaker filled with ice. Shake well and double strain into large cocktail glass. Garnish with lime wheel.", "1 1/4 oz, 1/4 oz, 1/4 oz, 1/4 cup", "Cosmopolitan", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d8e44da7-b1d2-4114-8b35-0fade421b221"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/eaag491504367543.jpg", "Champagne, Peach schnapps", "Pour peach pur�e into chilled flute, add sparkling wine. Stir gently.", "6 oz, 1 oz", "Bellini", "ContemporaryClassic,IBA" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("31261803-cb9a-4589-8707-e092b4bee8ee"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/2j1m881503563583.jpg", "Jim Beam, Jack Daniels, Wild Turkey", "Pour one part Jack Daneils and one part Jim Beam into shot glass then float Wild Turkey on top.", "1 part, 1 part, 1 oz", "Shot-gun", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("fb20e8a5-e88f-4d0f-b65c-9ac82c6c35f7"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/6bec6v1503563675.jpg", "Southern Comfort, Triple sec, Lime, Sour mix", "Mix all ingredients, and pour over ice.", "2 oz, 1/2 oz, 2 wedges, 2 oz", "Bible Belt", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f3817314-2b9d-491a-909f-4573e0b474d8"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/yrhutv1503563730.jpg", "Baileys irish cream, Bourbon, Vodka, Orange juice", "Pour Irish Cream, Vodka, and Bourbon in a glass. Add some ice and mix in the orange juice.", "3/4 oz, 3/4 oz, 3/4 oz, 2-3 oz", "Irish Curdling Cow", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("fb752107-8b8e-4066-ae82-0ff052aee8bd"), null, "Milk / Float / Shake", "https://www.thecocktaildb.com/images/media/drink/j6rq6h1503563821.jpg", "Godiva liqueur, Milk", "Put 2 shots Godiva Liquour into a glass, add as much or as little milk as you would like.", "2 shots", "Sweet Tooth", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("50d0d24f-1ea7-4177-a7c4-9c00be52b64c"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/y36z8c1503563911.jpg", "Fruit punch, Sprite, Tequila, 151 proof rum", "Start with the Sprite. Next comes the tequila. After that, add the Minute Maid Fruit Punch, then float the 151. Rocks optional.", "2 part, 1 part, 2 shots, Float Bacardi", "Downshift", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("cbe0d46f-f73c-4a36-a5b4-a6fea417c700"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/6vigjx1503564007.jpg", "Everclear, Vodka, Peach schnapps, Orange juice, Cranberry juice", "mix all ingredients into bowl keep iced stir frequently", "750 ml, 1750 ml, 1750 ml, 1 gal, 1 gal", "Pink Penocha", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("dfbcc2a6-5a64-4d29-b5a3-6b2f3e2e668e"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/rdvqmh1503563512.jpg", "Rum, Vodka, Tequila, Gin, Triple sec, Chambord raspberry liqueur, Midori melon liqueur, Malibu rum", "Pour all ingredients over ice in a very tall glass. Sip cautiously.", "1 oz, 1 oz, 1 oz, 1 oz, 1 oz, 1 oz, 1 oz, 1 oz", "Radioactive Long Island Iced Tea", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("62d9c527-28da-4c2e-be31-2a567610edcc"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/ttyrxr1454514759.jpg", "Orange juice, Rum, Vodka, Cream, Ice", "Pour ingredients over ice and stir.", "4 oz, 1 oz, 1 oz, 1 package, Over", "Orange Whip", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("58409c3f-2291-4726-83cc-c1e752f1ce03"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/p5r0tr1503564636.jpg", "Dark rum, Vodka, Triple sec, Tequila, Melon liqueur, Mountain Dew", "Add all ingredients in collins glass with ice and stir.", "1/2 oz, 1/2 oz, 1/2 oz, 1/2 oz, 1/2 oz, Fill with", "Gideon's Green Dinosaur", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a55fe876-f911-497f-8c8c-df217aec2a59"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/rptuxy1472669372.jpg", "Amaretto, Lemon, Ice, Maraschino cherry", "Rub the rim of an old fashioned glass with lemon, and dip repeatedly into granulated sugar until it has a good \"frosted\" rim. Shake a jigger of Amaretto with the juice of 1/2 a lemon. Strain into glass and add ice. Garnish with a Marachino Cherry.", "1 jigger, Juice of 1/2", "A True Amaretto Sour", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("0e364238-0311-44b4-9bba-4de6740fa13e"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/hfp6sv1503564824.jpg", "151 proof rum, Kool-Aid", "Add Kool Aid to a double shot glass, and top with rum. Slam and shoot.", "2 oz light, 1/2 tsp Tropical", "Kool First Aid", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("62834dc8-1c7a-47f6-9469-5ca8501964a2"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/vw7iv91493067320.jpg", "J�germeister, Goldschlager", "Mix in spread glass over ice. Strain and pour in shot glass. Sit down before shotting. ENJOY!!", "1 oz, 1 oz", "Auburn Headbanger", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4396c85d-8f25-4027-ab16-c00f7791870e"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/1wifuv1485619797.jpg", "Zima, Chambord raspberry liqueur", "Fill glass with ice. Pour in Chambord, then fill with Zima. Mix and enjoy.", "12 oz, 3 oz", "Zima Blaster", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("37ceb8b8-a6ad-4101-8df6-eb34fa9cb314"), null, "Beer", "https://www.thecocktaildb.com/images/media/drink/upvtyt1441249023.jpg", "Corona, Bacardi Limon", "Pour the corona into an 18oz beer glass pour the bacardi limon into the beer stir very gently", "1, 1 shot", "Buccaneer", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("34ea0f3c-7e7d-48b4-9770-a60085cb51ba"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/7if5kq1503564209.jpg", "Vodka, Chambord raspberry liqueur, Peachtree schnapps, Cranberry juice", "Pour all ingredients in a mixing tin over ice, stir, and strain into shot glass", "1/2 oz, 1/2 oz, 1/2 oz, 1/2 oz", "Bruised Heart", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("00d02efb-2d8f-43b4-8fe7-520cb8932a31"), null, "Homemade Liqueur", "https://www.thecocktaildb.com/images/media/drink/uwtsst1441254025.jpg", "Sugar, Corn syrup, Coffee, Vanilla extract, Water, Vodka", "Dissolve sugar in 2 cups of boiling water and add corn syrup. Dissolve the instant coffee in the remaining water. Pour syrup and coffee in a gallon jug. Let it cool. Add vodka and vanilla when cold. For the best result, let the mixture \"mature\" for 4-5 weeks.", "2 1/2 cups, 1 cup, 1 1/2 oz instant, 2 oz, 3 cups boiling, 1 fifth", "Homemade Kahlua", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a27c83a7-ad4c-4aad-b3d9-d04c3b2cca83"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/xwxyux1441254243.jpg", "Vodka, Half-and-half, Limeade, Ice, Nutmeg", "Blend all ingredients, save nutmeg. Pour into large white wine glass and sprinkle nutmeg on top.", "2 oz, 2 oz, 2 oz", "Vodka Fizz", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a5fb6cdd-8e7d-4627-8ff1-ca3c82e5244c"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/qspqxt1472720078.jpg", "Apple juice, Malibu rum, Cinnamon", "Just mix the two liquids and sprinkle in the cinnamon. Serve either cold or heated.", "3 parts, 1 part, 3 dashes", "Apple Pie with A Crust", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5439656e-3541-4180-a0e9-5db8b3a0672f"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/kjnt7z1504793319.jpg", "Ice, Tennessee whiskey, Vanilla extract, Coca-Cola", "After pouring in your ingredients, and adding 3-5 ice cubes, according to taste. Stir the drink with a stirrer to get the Vanilla off the bottom.", "4-5, 2 oz, 1 tsp, 10-12 oz", "Jack's Vanilla Coke", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("0795a4b0-5485-4049-b901-4be2474394a2"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/wqrptx1472668622.jpg", "Tequila, Apple cider", "Chill both ingredients!! Mix in a tumbler and enjoy!", "3 oz, 12 oz", "Apple Grande", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d6eb7ff7-29c9-4d9a-9b32-fe93feb86665"), null, "Soft Drink / Soda", "https://www.thecocktaildb.com/images/media/drink/usuvvr1472719118.jpg", "Dark rum, Orange, Surge, Cranberry juice", "Pour Shot of Rum over slice of orange. Fill the remaining space in glass half way full of surge or similar drink. Finish off glass with cranberry juice. Be carefull, warm surge may foam over the glass.", "1 shot, 1 slice, 1/2 glass, 1/2 glass", "Bleeding Surgeon", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("2e8629be-dc72-4054-963d-bcde30c762f3"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/rwqxrv1461866023.jpg", "Kahlua, Sambuca, Grand Marnier", "Layer the Kahlua, Sambucca and Grand Marnier into a shot glas in that order. Better than B-52", "1/3 shot, 1/3 shot, 1/3 shot", "B-53", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7c96ed53-ea44-4f46-b8da-d493078857a5"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/tpxurs1454513016.jpg", "Rum, Vodka, Tequila, Triple sec, Fruit, Ice, Salt, Fruit juice", "Add ice to blender (or to glass if prefer on the rocks) then fruit, and fruite juice depending on personal prefference then add the Rum, Vodka, Tequila, and triple sec. blend till smooth, rim glass with sugar or salt and pour mixture in. garnish with lemon or lime slice.", "1 part, 1 part, 1 part, 1/2 part, 1-3 pint", "Adam Bomb", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("2bef0434-1660-47ab-b075-907b2c60c3a5"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/dbtylp1493067262.jpg", "Vodka, Midori melon liqueur, Sweet and sour", "Pour all ingredients into shot glass and slam !!!!", "1/3 oz, 1/3 oz, 1/3 oz", "Arizona Antifreeze", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b2ef0e1f-0929-46bf-860b-dbf25e91e1e5"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/wtkqgb1485621155.jpg", "Vodka, Ouzo", "Prepare like a Martini. Garnish with a green olive.", "1 1/4 oz Stoli, 1/4 oz", "Zorbatini", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("9e02e125-2c7b-4b01-82f8-ba0324628e58"), null, "Beer", "https://www.thecocktaildb.com/images/media/drink/wwuvxv1472668899.jpg", "Guinness stout, Root beer", "CAREFULLY to avoid explosive head formation: Pour Beer glass half full of favorite rootbeer and top off with Guinness.", "1/2, 1/2", "Black and Brown", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("864fbde4-6593-4be7-a0db-3cc5bfb5a7a8"), null, "Milk / Float / Shake", "https://www.thecocktaildb.com/images/media/drink/uppqty1472720165.jpg", "Crown Royal, Kahlua, Cream", "Mix in highball glass over ice, shake well.", "1 shot, 1 shot, Fill with", "Avalanche", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("04d68a6c-00a5-4045-a9a3-5ecefbbc19fd"), null, "Soft Drink / Soda", "https://www.thecocktaildb.com/images/media/drink/xspxyr1472719185.jpg", "Vanilla ice-cream, Coca-Cola, Bourbon", "Scoop two large scoops of vanilla ice-cream into frosted beer mug. Next, add 2 ounces Maker's Mark. Then, pour in coke. Gently stir and enjoy.", "2 scoops, 1 can, 2 oz", "Brandon and Will's Coke Float", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("df9a9edf-28d3-4bc9-988e-269c44e8a849"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/yywpss1461866587.jpg", "Kahlua, Sambuca, Blue Curacao, Baileys irish cream", "Pour the Sambuca and Kahlua into the Cocktail Glass and give the drinker a straw. Pour the Baileys and Blue Curacao into two sepsrate shot glasses either side of the cocktail glass. Set light the concotion in the cocktail glass and start to drink through the straw (this drink should be drunk in one) , as the bottom of the glass is reached put out the fire by pouring the Baileys and Blue Curacao into the cocktail glass and keep drinking till it's all gone!!", "1 oz, 1 oz, 1 oz, 1 oz", "Flaming Lamborghini", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("8b940c96-36fe-4260-9172-2af0e505b4fd"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/r2qzhu1485620235.jpg", "Chambord raspberry liqueur, Vodka, Soda water", "Fill glass with rocks, add straw before putting in liquor. Then add the ingredients in order, trying to keep layered as much as possible (i.e. Chambord on bottom, then Vodka, Then soda on top).", "1 shot, 1 shot, Fill with", "Zipperhead", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("26a68e9c-d802-4ee8-9bf7-72aab28eae85"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/wysqut1461867176.jpg", "Vodka, Peach schnapps, Orange juice, Cranberry juice", "Shaken, not stirred!", "1 oz, 1 oz, 3 oz, 3 oz", "A Gilligan's Island", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("df43b2bc-0e19-4a42-9b88-03e1f687f8a6"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/uppqty1441247374.jpg", "Kahlua, Brandy, Coffee", "Stir. Add whipped cream to the top.", "1 oz, 1/2 oz", "Kioki Coffee", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("bf4d1776-b970-4733-aea5-7a9acee2e5a0"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/tqxyxx1472719737.jpg", "Amaretto, Southern Comfort, Ice, Sour mix", "Put ice in glass. Pour in shots. Fill with Sour Mix.", "1 shot, 1 shot, cubes", "A Piece of Ass", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("54ce21bd-fccb-4f46-a0ab-84a2cad53e54"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/yyrwty1468877498.jpg", "Goldschlager, J�germeister, Rumple Minze, 151 proof rum", "Add over ice,shake and pour.", "1/2 oz, 1/2 oz, 1/2 oz, 1/2 oz Bacardi", "24k nightmare", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("23f2f402-260a-4d7a-ab72-04e66aab22ae"), null, "Beer", "https://www.thecocktaildb.com/images/media/drink/svsxsv1454511666.jpg", "Corona, Light rum", "Pour the Corona into an 18oz beer glass pour the rum into the beer.", "1 bottle, 1 shot", "Caribbean Boilermaker", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b264a168-a23f-4075-bed5-fa4a85f4b243"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/55muhh1493068062.jpg", "Vodka, Gin, Lime juice cordial, Ice", "Pour Vodka, Gin and lime cordial into glass, and top up with crushed ice. Wait for ice to melt slightly and sip without a straw.", "30 ml, 30 ml, 45 ml, 1/2 glass crushed", "Army special", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7775717e-7564-4008-9509-10f92867c9e7"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/vcyvpq1485083300.jpg", "Vodka, Dry Vermouth, Olive Brine, Lemon, Olive", "Pour the vodka, dry vermouth and olive brine into a cocktail shaker with a handful of ice and shake well.\r\nRub the rim of a martini glass with the wedge of lemon.\r\nStrain the contents of the cocktail shaker into the glass and add the olive.\r\nA dirty Martini contains a splash of olive brine or olive juice and is typically garnished with an olive.", "70ml/2fl oz, 1 tbsp, 2 tbsp, 1 wedge, 1", "Dirty Martini", "IBA,NewEra" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("69be09de-9bf7-4efe-bd25-a1e843a427ea"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/g51naw1485084685.jpg", "Pisco, Lime Juice, Pineapple Syrup, St. Germain, Angostura Bitters, Pepper, Lavender", "Shake all ingredients.\r\nDouble strain in a chilled double old fashioned glass with abig ice cube.\r\nGarnish with a couple of lavender sprigs", "5 cl, 2.5 cl, 2.5 cl, 1.5 cl, 2 Dashes, Pinch, 2 sprigs", "Duchamp's Punch", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f04310db-7f29-4d16-8c67-9b76cebb90b9"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/n433t21504348259.jpg", "Light rum, Lime juice, Sugar syrup, Grenadine", "Shake together with ice. Strain into glass and serve.", "1 3/4 oz Bacardi, 1 oz, 1/2 tsp, 1 dash", "Bacardi Cocktail", "IBA,Classic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("eefb57a5-83d3-4ccf-a5dd-a0fb0f3e0005"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/of1rj41504348346.jpg", "Brandy, Light rum, Triple sec, Lemon juice", "Pour all ingredients into shaker with ice cubes, shake, strain into chilled cocktail glass.", "1 oz, 1 oz, 1 oz, 1 oz", "Between The Sheets", "IBA,Classic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("136d9f36-ae88-4d02-9287-ae62fed80299"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/1mvjxg1504348579.jpg", "Gin, Maraschino liqueur, Lemon juice, Orange bitters, Cherry", "Pour all ingredients into shaker with ice cubes. Shake well. Strain into chilled cocktail glass. Garnish with a lemon twist and a maraschino cherry. Serve without a straw.", "2 oz, 1/4 tsp, 1/4 tsp, 2 dashes, 1", "Casino", "IBA" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("42ad3de3-11e8-46da-b7e9-d0b59a06803b"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/t0aja61504348715.jpg", "Gin, Grenadine, Lemon, Egg white", "Dry shake ingredients to emulsify, add ice, shake and served straight up.", "1 1/2 oz, 2 tsp, Juice of 1/2, 1", "Clover Club", "IBA,Classic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5ca5ec2d-d29b-4a7b-a286-31654c9a407a"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/ruutxt1478253328.jpg", "Gin, lemon juice, maraschino liqueur", "Add all ingredients into cocktail shaker filled with ice. Shake well and strain into cocktail glass. Garnish with a cherry.", "4.5 cl, 1.5 cl, 1.5 cl", "Aviation", "IBA,Classic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b6a07aa4-1209-47a1-9c38-2e4a45804f0c"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/i502ra1504349156.jpg", "gin, Peach Bitters, Mint", "Pour all ingredients into a mixing glass with ice. Stir. Strain into a cocktail glass. Garnish with a sprig of fresh mint in the drink.", "6 cl, 2 dashes, 2 Fresh leaves", "Derby", "Classic,IBA" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a0e43818-fa2d-4795-93bb-1411d10ed3db"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/94psp81504350690.jpg", "Gin, Benedictine, Orange juice, Grenadine", "Shake well over ice cubes in a shaker, strain into a chilled cocktail glass.", "2 oz, 1 tsp, 1/2 oz, 1 tsp", "Monkey Gland", "IBA,Classic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c00e9760-adc7-4a10-9e3c-01fda02d3267"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/ejozd71504351060.jpg", "Gin, Apricot Brandy, Orange Juice", "Shake together over ice. Strain into cocktail glass and serve chilled.", "7 parts, 4 parts, 3 parts", "Paradise", "IBA" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("e865a6a2-44cf-47bc-a360-8f16b3dd7d83"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/yvos231504351384.jpg", "Dark rum, Orgeat syrup, Orange juice, Pineapple juice", "Pour all ingredients, except the bitters, into shaker filled with ice. Shake well. Pour into large glass, filled with ice. Add Angostura bitters, \"on top\". Garnish with cocktail cherry and pineapple.", "1 part, 1/2 part, 2 parts, 1 part", "Planter's Punch", "IBA,Classic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d99b4383-bf9d-4d93-8c92-8d2980894a8e"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/64x5j41504351518.jpg", "Brandy, Port, Egg Yolk", "Shake ingredients together in a mixer with ice. Strain into glass, garnish and serve.", "3 parts, 9 parts, 2 parts", "Porto flip", "IBA,Classic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("91d982a4-ebf6-463a-98f7-19a913d119fb"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/2ahv791504352433.jpg", "Brandy, White Creme de Menthe", "Pour in a mixing glass with ice, stir and strain into a cocktail glass. May also be served on rocks in a rocks glass.", "1 1/2 oz, 1/2 oz", "Stinger", "IBA,Classic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("519c50cc-86d1-40d0-9022-930bcc2210dd"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/jofsaz1504352991.jpg", "Gin, Triple Sec, Lemon Juice", "Add all ingredients into cocktail shaker filled with ice. Shake well and strain into large cocktail glass.", "4cl, 3cl, 2cl", "White Lady", "IBA,Classic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("6e1c3992-ed66-4f19-8602-5c5b23bb4384"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/f9erqb1504350557.jpg", "Light rum, Pineapple juice, Maraschino liqueur, Grenadine, Maraschino cherry", "Shake and strain into a chilled large cocktail glass", "1 1/2 oz, 1 oz, 1/2 tsp, 1/2 tsp, 1", "Mary Pickford", "IBA,Classic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("6eec4b3c-6d69-47d7-a155-dadfba108800"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/uuytrp1474039804.jpg", "Baileys irish cream, Chambord raspberry liqueur, Sugar syrup, Sugar", "Coat the rim of a shot glass with sugar using sugar syrup to stick. Add the Chambord raspberry liqueur to the shot glass, and carefully layer the Baileys Irish Cream on top. Serve.", "2/3 oz, 1/3 oz, 1 tsp, 2 pinches", "Jam Donut", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4beaf7ed-7502-43ad-b3b6-2f82e667bef0"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/uwstrx1472406058.jpg", "demerara Sugar, Lime, Cachaca", "Muddle the sugar into the lime wedges in an old-fashioned glass.\r\nFill the glass with ice cubes.\r\nPour the cachaca into the glass.\r\nStir well.", "2 tsp, 1, 2 1/2 oz", "Dark Caipirinha", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("0f3d44ca-d085-42e0-a6d7-b3a62efcae6f"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/yswuwp1469090992.jpg", "Lime, Brown sugar, Passion fruit juice, Ginger ale, Ice", "Cut half a lime into pieces, place in a shaker, add the sugar and crush. Measure the passion fruit juice, add it to the shaker and fill up with ice cubes. Close the shaker and shake vigorously. Pour the liquid into a glass, top up with ginger ale, stir with a teaspoon and then garnish the rim of the glass with a slice of lime", "�, 2 tsp, 4 cl, top up with, fill", "Ipamena", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("bb06cc7f-4541-4400-9518-b4cacc57ff30"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/ido1j01493068134.jpg", "Vodka, Malibu rum, Gold tequila, Orange juice, Pineapple juice, Cream of coconut, Grenadine, Ice, Pineapple", "Just mix in the shots of rum, vodka, and tequila. Add splashes of the three juices, heavy on the pineapple. Top off with grenadine. Crushed ice should already be in glass. Top off the glass with a pineapple wedge.", "1 shot, 1 shot, 1 shot, 1 splash, 1 splash, 1 splash, 1 dash, crushed, 1 wedge", "Arizona Twister", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a6544a85-4588-4a76-9c68-61ec2b6742c0"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/rvyvxs1473482359.jpg", "Kahlua, Baileys irish cream", "Pour Kahlua, almost filling shot glass. Then, carefully pour Baileys, using wall of shot glass. This will give the \"Guinness\" its \"head\".", "2 1/2 oz, 1/2 oz", "Baby Guinness", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("8b626602-3979-44f7-bd64-93e162f8598a"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/g12lj41493069391.jpg", "Amaretto, Grand Marnier, Southern Comfort", "Just mix the three ingredients one to one to one", "1 shot, 1 shot, 1 shot", "Alice in Wonderland", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("e1b7ea08-a999-439b-a314-873f6f2ce973"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/ywxwqs1461867097.jpg", "Blue Curacao, Blueberry schnapps, Vodka, Sour mix, 7-Up", "Mix equal amounts into a glass with ice.", "", "501 Blue", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4c035e4e-c82a-4969-86f9-6ec3d33b1a57"), null, "Soft Drink / Soda", "https://www.thecocktaildb.com/images/media/drink/yrtxxp1472719367.jpg", "Coca-Cola, Lemon juice", "Take a glass, pour the Coke in the glass, then you take 7 drops of lemon juice. Granish with a lemon slice on the rim of the glass.", "1 dl, 7 drops", "Coke and Drops", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("fb5acb43-dbf0-4936-a29b-91a809e085ef"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/qsyqqq1441553437.jpg", "Gin, Cranberry juice, Grenadine", "Pour gin and cranberry into a highball filled with ice cubes. Add grenadine and stir.", "2 oz, 5 oz, 2 splashes", "Ruby Tuesday", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("cc58a99a-797f-43c3-b24f-76fbd6e4737a"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/wqstwv1478963735.jpg", "Maui, Mountain Dew, Ice", "Blend all ingredients in a blender on high until ice is finely crushed. It should be of a slushy consistency. Pour immediately and serve.", "5 oz blue, 5 oz, cubes", "Arctic Mouthwash", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("dfc042da-bdbf-43bc-a69b-1d94a52dffeb"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/rz5aun1504389701.jpg", "Everclear, Vodka, Mountain Dew, Surge, Lemon juice, Rum", "Mix all ingredients together. Slowly and gently. Works best if ice is added to punch bowl and soda's are very cold.", "1 fifth, 1 fifth Smirnoff red label, 2 L, 2 L, 1 small bottle, 1 pint", "Brain Fart", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("ad26cc38-b9b3-4bcf-8b7a-32bfdc36888e"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/qupuyr1441210090.jpg", "Frangelico, Crown Royal", "Into a shot glass layer the Crown Royal on top of the Frangelico.", "1 part, 1 part", "Royal Bitch", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("fb34e9ab-3472-4586-9072-57558a539def"), null, "Soft Drink / Soda", "https://www.thecocktaildb.com/images/media/drink/uyrvut1479473214.jpg", "Bacardi Limon, Coca-Cola", "Pour half of coke in a glass. Then add Bacardi and top it off with the remaining coke. Stir and drink up!", "1 part, 2 parts", "Citrus Coke", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("ffba82d3-f179-4e49-8226-5f4e89eb3650"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/rx8k8e1504365812.jpg", "Red wine, Peach schnapps, Pepsi Cola, Orange juice", "Throw it all together and serve real cold.", "1/3 part, 1 shot, 1/3 part, 1/3 part", "Smut", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("264b6bbb-2a0f-495b-aa47-70f23091f1ec"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/suqyyx1441254346.jpg", "Raspberry vodka, Lemon-lime soda, Ice", "Pour the raspberry vodka and soda into a highball glass almost filled with ice cubes. Stir well.", "2 oz, 4 oz", "Raspberry Cooler", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("ce73efc0-6c90-4efd-bec3-4c4388adb63e"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/apictz1493069760.jpg", "Triple sec, Amaretto, Cider, Ice", "Shake ingredients in bartender's mixer quickly, just 5 shakes. Strain out ice, serve in glass immediately with a slice of orange.", "1/2 jigger, 3 shots, 1/2 cup, Add 1/2 cup", "Amaretto Sunset", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("edb4ce4f-bd71-478a-bbfe-4789b6455c90"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/tquyyt1451299548.jpg", "Gin, Tequila, Vodka, White rum, Triple Sec, Cherry Grenadine, Sweet and sour, Club soda", "Now stir vigorously and then pour over a large cup of ice. Now drink it with a straw and stir occasionally.", "1 oz, 1 oz, 1 oz, 1 oz, 1 oz, 1 oz, 1 oz, 3 oz", "Cherry Electric Lemonade", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b6335e21-8de7-4370-9b2b-007d7328a3ca"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/xypspq1469090633.jpg", "Cachaca, Lemon Juice, Agave Syrup, Champagne", "Add the cachaca, lemon juice and syrup to your boston glass. Add ice and shake until ice cold. Pour into a chilled flute and top-up with Champagne", "25 ml, 15 ml, 10 ml, top up with", "Girl From Ipanema", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("3d31e0eb-eb98-4d8e-8aa5-5f37521d7bc2"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/ojnpz71504793059.jpg", "Creme de Cacao, Blue Curacao, Light rum", "Pour ingredients into glass, and drop in a blue whale! The blue whale isn't really necessary, but it makes the drink more \"fun\".", "1 1/2 oz, 1 oz, 1/2 oz", "The Evil Blue Thing", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("3f0f0895-922f-47e8-b630-a73a14851d27"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/j6q35t1504889399.jpg", "Chocolate liqueur, Milk, Amaretto", "Put the milk in the bottom, pour the Liquer on top and add the dash of amaretto. Do not mix. SLAM IT!", "1/2 shot, 1/2 shot, 1 dash", "Chocolate Milk", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("675aee60-bc51-48e2-a967-f6daf6af82d0"), null, "Beer", "https://www.thecocktaildb.com/images/media/drink/swqurw1454512730.jpg", "Vodka, Kahlua, Coca-Cola, Guinness stout", "Add the ingredients in the order listed in the recipe. Care must be taken when adding the Guinness to prevent an excess of foam. Do Not add ice.", "1 shot, 1 shot, 1 dash, Fill with", "Irish Russian", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d7b9d34d-1bd2-4dd2-8208-de952825b84b"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/yqwuwu1441248116.jpg", "Irish cream, Goldschlager", "Pour ingredients into 1 ounce shot glass", "1/2 oz, 1/2 oz", "Big Red", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("fccc2023-a6c9-469c-9a22-9fd896db061a"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/l9gi5h1504820724.jpg", "Gin, Water, Powdered sugar, Lemon peel", "Mix powdered sugar and water in an old-fashioned glass. Add gin and one ice cube. Stir, add the twist of lemon peel, and serve.", "2 oz, 2 tsp, 1/2 tsp, 1 twist of", "Gin Toddy", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7a838551-bb4f-4cba-940a-e321949f5fae"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/m5nhtr1504820829.jpg", "Vodka, Amaretto, Heavy cream", "Shake all ingredients well with cracked ice, strain into a champagne flute, and serve.", "1 oz, 1 oz, 1 oz", "Godchild", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("df4056d3-191a-4c30-8246-0c1b45710c38"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/r74uz51504368928.jpg", "Scotch, Amaretto", "Pour all ingredients directly into old fashioned glass filled with ice cubes. Stir gently.", "1 1/2 oz, 3/4 oz", "Godfather", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("088305e0-0471-4e35-ba63-7e5404a3738c"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/4889up1504368984.jpg", "Vodka, Amaretto", "Pour vodka and amaretto into an old-fashioned glass over ice and serve.", "1 1/2 oz, 3/4 oz", "Godmother", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f51cfc9e-9443-41da-af13-56e9e2cd8be8"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/qyvprp1473891585.jpg", "Gin, Triple sec, Pineapple juice, Grenadine, Pineapple", "In a shaker half-filled with ice cubes, combine the gin, triple sec, pineapple juice, and grenadine. Shake well. Pour into an old-fashioned glass and garnish with the pineapple slice.", "1 1/2 oz, 1 oz, 1 oz, 1/2 tsp, 1", "Grass Skirt", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("27503bf1-8969-4543-8615-915385cc4c61"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vg4bva1504369725.jpg", "Vodka, Galliano, Orange juice", "Stir the vodka and orange juice with ice in the glass, then float the Galliano on top. Garnish and serve.", "1 oz, 1/2 oz, 4 oz", "Harvey Wallbanger", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("93ba6d94-cbfb-45b7-9955-4c749f4d1ae5"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/sybce31504884026.jpg", "Lime juice, Sugar, Gin, Bitters, Club soda", "In a shaker half-filled with ice cubes, combine the lime juice, sugar, gin, and bitters. Shake well. Almost fill a colling glass with ice cubes. Stir until the glass is frosted. Strain the mixture in the shaker into the glass and add the club soda.", "1 1/2 oz, 1 tsp superfine, 2 oz, 1 dash, 3 oz", "Gin Swizzle", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d358f2c8-da0c-426b-b0e0-f32061613358"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/59splc1504882899.jpg", "Light rum, Pineapple juice, Lemon juice", "In a shaker half-filled with ice cubes, combine all of the ingredients. Shake well. Strain into a cocktail glass.", "1 oz, 1 oz, 1 tsp", "Havana Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("e1bed2e4-1d22-4a37-bade-b4772be36f1b"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/0bkwca1492975553.jpg", "Scotch, Sweet Vermouth, Orange bitters, Olive", "Stir all ingredients (except olive) with ice and strain into a cocktail glass. Add the olive and serve.", "1 1/2 oz, 3/4 oz, 2 dashes, 1", "Highland Fling Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("033b6ea5-b149-4293-b7ec-dcdf9b38457c"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/zj1usl1504884548.jpg", "Light rum, Blended whiskey, Lemon, Powdered sugar, Carbonated water", "Shake all ingredients (except carbonated water) with ice and strain into a highball glass over two ice cubes. Fill with carbonated water, stir, and serve.", "1/2 oz, 1 1/2 oz, Juice of 1/2, 1 tsp", "Imperial Fizz", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("de190d2b-1c89-4fc8-9a11-97cd5fef5cb9"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/sot8v41504884783.jpg", "Irish whiskey, Peach brandy, Orange juice, Sweet and sour, Orange, Cherry", "Pour all ingredients (except orange slice and cherry) into a collins glass over ice cubes. Garnish with the slice of orange, add the cherry on top, and serve.", "1 oz, 1/2 oz, 1 oz, 1 oz, 1 slice, 1", "Irish Spring", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("6eb4b38c-2b62-4f01-a0f0-7d11894f8700"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/uuqqrv1439907068.jpg", "Apple brandy, Grenadine, Lime", "Shake all ingredients with ice, strain into a cocktail glass, and serve.", "1 1/2 oz, 1 tsp, Juice of 1/2", "Jack Rose Cocktail", "Beach" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7e850bcb-f0b3-4ce7-a302-9df66bce3b79"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/37vzv11504884831.jpg", "Blended whiskey, Lemon, Powdered sugar, Port, Egg white, Carbonated water", "Shake all ingredients (except carbonated water) with ice and strain into a highball glass over two ice cubes. Fill with carbonated water, stir, and serve.", "1 1/2 oz, Juice of 1/2, 1 tsp, 1 tblsp, 1", "Japanese Fizz", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("eac4b67d-896d-4628-9e60-ac5981dbdcef"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/hx4nrb1504884947.jpg", "Gin, Green Chartreuse, Yellow Chartreuse", "In a mixing glass half-filled with ice cubes, combine all of the ingredients. Stir well. Strain into a cocktail glass.", "1 1/2 oz, 1/2 oz, 1/2 oz", "Jewel Of The Nile", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("430c61eb-3169-424d-97ec-c7da3ae4f091"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/ujoh9x1504882987.jpg", "Gin, Triple sec, Pineapple juice", "Shake all ingredients with ice, strain into a cocktail glass, and serve.", "2 oz, 1/2 oz, 1 tblsp", "Hawaiian Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("2546d870-a271-479d-8d70-5967caa48331"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/u5yaxl1504350270.jpg", "Bourbon, Lemon juice, Sugar, Club soda, Maraschino cherry, Orange", "Pour all ingredients directly into highball glass filled with ice. Stir gently. Garnish. Add a dash of Angostura bitters.", "2 oz, 1 oz, 1 tsp superfine, 3 oz, 1, 1", "John Collins", "IBA" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("fa909d15-0e38-4b69-9f1a-892c007743f7"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/xrbhz61504883702.jpg", "Gin, Grenadine, Powdered sugar, Pineapple, Strawberries, Carbonated water", "Stir gin, grenadine, and powdered sugar with ice and strain into a highball glass over ice cubes. Fill with carbonated water and stir. Decorate with the pineapple chunks and the strawberries and serve.", "1 1/2 oz, 1 tsp, 1 tblsp, 3 chunks, 2", "Gin Squirt", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c5759d8c-51d9-4245-82cb-6e00be089271"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/hp41fi1504883656.jpg", "Gin, Carbonated water, Sugar, Mint, Orange, Cherry", "Muddle sugar with carbonated water and mint sprigs in an old-fashioned glass. Add gin and 1 ice cube. Stir, add the orange slice and the cherry, and serve.", "2 oz, 1 oz, 1 cube, 4, 1 slice, 1", "Gin Smash", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("82a154c1-b369-49ef-abff-fe44eac525ce"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/akik8t1504519958.jpg", "Gin, Triple sec", "In an old-fashioned glass almost filled with ice cubes, combine the gin and triple sec. Stir well.", "2 oz, 1/2 oz", "Flying Dutchman", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("859d002b-26dc-4eb2-8b85-46def1fc4147"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/glgrix1504520040.jpg", "Scotch, Sweet Vermouth, Bitters, Sugar syrup", "Shake all ingredients with ice, strain into a cocktail glass, and serve.", "1 oz, 1 oz, 1 dash, 1/4 tsp", "Flying Scotchman", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4a38a51b-8c08-4cf7-8000-cb014d1255c1"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/r9cz3q1504519844.jpg", "Amaretto, Creme de Cacao, Light cream", "Shake all ingredients with ice, strain into a chilled cocktail glass, and serve.", "1/2 oz, 1/2 oz, 2 oz", "Foxy Lady", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5b0d8027-1880-43ea-b5f6-a08a317405e4"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/qpvxsx1439906903.jpg", "Gin, Sugar, Lemon juice, Champagne, Orange, Maraschino cherry", "In a shaker half-filled with ice cubes, combine the gin, sugar, and lemon juice. Shake well. Pour into a collins glass. Top with the Champagne. Stir well and garnish with the orange slice and the cherry.", "1 1/2 oz, 2 tsp superfine, 1 1/2 oz, 4 oz Chilled, 1, 1", "French \"75\"", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("cec1e3a3-705e-4f87-9e41-d7cfc1de440b"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/y39l941504884150.jpg", "Blended whiskey, Benedictine, Lemon, Lime, Lemon, Lime", "Shake all ingredients (except slices of lemon and lime) with ice and strain into a whiskey sour glass. Decorate with the slices of lemon and lime and serve.", "2 oz, 1/2 oz, Juice of 1/4, Juice of 1/2, 1 slice, 1 slice", "Frisco Sour", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("3ec20b08-43b1-4c90-8b12-27c97dd76f45"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/7oyrj91504884412.jpg", "Light rum, Triple sec, Lime juice, Sugar, Cherry, Ice", "Combine all ingredients (except for the cherry) in an electric blender and blend at a low speed for five seconds, then blend at a high speed until firm. Pour contents into a champagne flute, top with the cherry, and serve.", "1 1/2 oz, 1 tblsp, 1 1/2 oz, 1 tsp, 1, 1 cup crushed", "Frozen Daiquiri", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4e6f3b15-1ac6-439f-8384-15c658363999"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/mt7l7m1504883523.jpg", "Gin, Lemon juice, Sugar, Orange, Maraschino cherry", "In a shaker half-filled with ice cubes, combine the gin, lemon juice, and sugar. Shake well. Strain into a sour glass and garnish with the orange slice and the cherry.", "2 oz, 1 oz, 1/2 tsp superfine, 1, 1", "Gin Sour", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("9dc1c7c7-c9c9-484f-b405-6efa6b14b3b9"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/jrhn1q1504884469.jpg", "Light rum, Lime juice, Mint, Sugar", "Combine all ingredients with 1 cup of crushed ice in an electric blender. Blend at a low speed for a short length of time. Pour into an old-fashioned glass and serve.", "2 oz, 1 tblsp, 6, 1 tsp", "Frozen Mint Daiquiri", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("1f001c70-e8dd-4eb4-81e0-dad1b5d4d072"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/ezvy1c1504883335.jpg", "Gin, Brandy, Sweet Vermouth, Club soda", "In an old-fashioned glass almost filled with ice cubes, combine all of the ingredients. Stir well.", "1 1/2 oz, 1 oz, 1 oz, 1 oz", "Gentleman's Club", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a951dbd3-b2f6-4867-941d-6b8d1f0ea0b9"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/wtyxvx1472405831.jpg", "Gin, Tonic water, Lime", "Pour the gin and the tonic water into a highball glass almost filled with ice cubes. Stir well. Garnish with the lime wedge.", "2 oz, 5 oz, 1", "Gin And Tonic", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d2db2325-5054-421c-9ca1-c562aef355d6"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/wsyrvv1478820109.jpg", "Gin, Carbonated water, Powdered sugar, Orange spiral, Lemon peel", "Stir powdered sugar and 2 oz. carbonated water in a collins glass. Fill glass with ice and add gin. Fill with carbonated water and stir. Add the lemon peel and the orange spiral so that the end of the orange spiral dangles over rim of glass.", "2 oz", "Gin Cooler", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7076ef33-f91d-4f9f-b157-82f728f48ce4"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/qwxysv1478819943.jpg", "Gin, Lemon juice, Sugar, Grenadine, Maraschino cherry, Orange", "In a shaker half-filled with ice cubes, combine the wine, lemon juice, sugar, and grenadine. Shake well. Pour into an old-fashioned glass and garnish with the cherry and the orange slice.", "2 oz, 1 oz, 1/2 tsp superfine, 1/2 tsp, 1, 1", "Gin Daisy", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4c4421df-482a-4f28-8e20-9551e66c8c36"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/xhl8q31504351772.jpg", "Gin, Lemon, Powdered sugar, Carbonated water", "Shake all ingredients with ice cubes, except soda water. Pour into glass. Top with soda water.", "2 oz, Juice of 1/2, 1 tsp", "Gin Fizz", "IBA,Classic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("0bbf489c-80aa-4a3a-9b84-77e00a0266b9"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/h8wmm41504883440.jpg", "Gin, Lemon, Powdered sugar, Water, Orange peel", "Dissolve powdered sugar in mixture of water and juice of lemon. Add gin. Pour into an old-fashioned glass over ice cubes and stir. Add the twist of orange peel and serve.", "2 oz, Juice of 1/2, 1 tsp, 1 tsp, Twist of", "Gin Sling", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("da704da1-52cc-4f4e-8c7d-78e80c340ef4"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/j2mqsb1504736097.jpg", "Light rum, Pineapple, Lime juice, Sugar", "Combine all ingredients with 1 cup of crushed ice in an electric blender. Blend at a low speed for a short length of time. Pour into a champagne flute and serve.", "1 1/2 oz, 4 chunks, 1 tblsp, 1/2 tsp", "Frozen Pineapple Daiquiri", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b18e71d5-6ca1-4278-8337-7d944f14737e"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/yxwrpp1441208697.jpg", "Apricot brandy, Gin, Dry Vermouth, Grenadine, Lemon juice, Cherry", "Rub rim of cocktail glass with lemon juice and dip rim of glass in powdered sugar. Shake all ingredients (except cherry) with ice and strain into sugar-rimmed glass. Top with the cherry and serve.", "3/4 oz, 1 1/2 oz, 3/4 oz, 1 tsp, 1/4 tsp, 1", "English Rose Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b264abc0-d2ab-446b-bc72-985b4ab41397"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/xa58bb1504373204.jpg", "Vodka, Triple sec, Lime juice", "Shake all ingredients together with ice. Strain into glass, garnish and serve.", "1 oz, 1 oz, 1 oz", "Kamikaze", "IBA,NewEra" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("db498347-ab06-417c-b021-95b4e5ff564e"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/utqwpu1478820348.jpg", "Bourbon, Benedictine, Lemon peel", "In a shaker half-filled with ice cubes combine the courbon and Benedictine. Shake and strain into a cocktail glass. Garnish with the lemon twist.", "3 oz, 1/2 oz, 1 twist of", "Kentucky Colonel", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("90e06948-bb25-47bf-a76e-1ca45083241b"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/wxvupx1441553911.jpg", "Grenadine, Green Creme de Menthe", "Pour carefully into a pousse-cafe glass, so that creme de menthe floats on grenadine. Serve without mixing.", "1 tblsp, 1/2 oz", "Port And Starboard", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("071344e1-0f27-47d2-8229-5df01a4542bd"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/qruprq1441553976.jpg", "Port, Brandy", "Stir ingredients with ice, strain into a cocktail glass, and serve.", "2 1/2 oz, 1/2 tsp", "Port Wine Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c8c4c1a6-5d40-4b81-83de-49af09e1636a"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vrprxu1441553844.jpg", "Port, Light cream, Powdered sugar, Egg, Nutmeg", "Shake all ingredients (except nutmeg) with ice and strain into a whiskey sour glass. Sprinkle nutmeg on top and serve.", "1 1/2 oz, 2 tsp, 1 tsp, 1 whole", "Port Wine Flip", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("aae895f9-790f-43ee-8e01-efc3ba108b24"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/yrqppx1478962314.jpg", "Light rum, Brandy, Lemon, Raspberry syrup", "Shake all ingredients with ice, strain into a cocktail glass, and serve.", "3/4 oz, 3/4 oz, Juice of 1/4, 2 tsp", "Quaker's Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("27fb45f1-0878-4d59-bce8-f35553fee09a"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/qrwvps1478963017.jpg", "Light rum, Sherry, Lime", "Stir all ingredients with ice, strain into a cocktail glass, and serve.", "1 1/2, 1/3 oz cream, Juice of 1/2", "Quarter Deck Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7d7ecdd6-3678-4de9-a055-f73ba3b73034"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/rvvpxu1478963194.jpg", "Coffee brandy, Lime vodka, Sherry", "Shake all ingredients with ice, strain into a cocktail glass, and serve.", "1 oz, 1 1/2 oz, 1/2 oz cream", "Queen Bee", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("ada72c2c-a86f-4c97-9530-ba42c140c82e"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/cslw1w1504389915.jpg", "Gin, Creme de Cacao", "Shake ingredients with ice, strain into a cocktail glass, and serve.", "1 1/2 oz, 3/4 oz white", "Poppy Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("340fc0bc-d0c8-4323-b135-f46a8f61af54"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vqruyt1478963249.jpg", "Red wine, Grenadine, Lemon-lime soda", "Pour red wine and grenadine into a collins glass over ice cubes. Fill with lemon-lime soda, stir, and serve.", "2 oz, 1 oz", "Queen Charlotte", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b04ae6fd-fd7b-48bf-a9e8-86263d01e542"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/spxtqp1478963398.jpg", "Dark rum, Kahlua, Light cream, Nutmeg", "In a shaker half-filled with ice cubes, combine the rum, Kahlua, and cream. Shake well. Strain into a cocktail glass and garnish with the nutmeg.", "1 1/2 oz, 1/2 oz, 1 oz, 1/8 tsp grated", "Quentin", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("fda68fd9-127b-4d21-a7d0-69b6700a135f"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/wrh44j1504390609.jpg", "Gin, Sweet and sour, Egg, Coca-Cola", "Shake all ingredients (except cola) with ice and strain into a chilled collins glass. Fill with cola and serve.", "1 oz, 2 oz, 1 whole", "Royal Fizz", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("94cf55be-d788-4b54-90e1-f8314c552495"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/pe1x1c1504735672.jpg", "Gin, Lemon, Powdered sugar, Egg, Carbonated water", "Shake all ingredients (except carbonated water) with ice and strain into a highball glass over two ice cubes. Fill with carbonated water, stir, and serve.", "2 oz, Juice of 1/2, 1 tsp, 1 whole", "Royal Gin Fizz", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("88e46620-055b-4cd9-addb-7366d85eb3cc"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/5vh9ld1504390683.jpg", "Sugar, Club soda, Lemon, Dark rum, Maraschino cherry, Orange", "In an old-fashioned glass, dissolve the sugar in the club soda. Add crushed ice until the glass is almost full. Add the rum. Stir well. Garnish with the cherry and the orange and lemon slices.", "1 tsp superfine, 3 oz, 1, 2 oz, 1, 1", "Rum Cobbler", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5514918f-e4cc-4613-a262-ecde856d27db"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/2hgwsb1504888674.jpg", "Rum, Lemon-lime soda, Lemon", "Pour the rum and soda into a collins glass almost filled with ice cubes. Stir well and garnish with the lemon wedge.", "2 oz light or dark, 4 oz, 1", "Rum Cooler", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7f1fc9ce-08cf-4aa7-9aac-72dea97ea2c4"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/w64lqm1504888810.jpg", "Light rum, Milk, Powdered sugar, Nutmeg", "Shake all ingredients (except nutmeg) with ice and strain into a collins glass. Sprinkle nutmeg on top and serve.", "2 oz, 1 cup, 1 tsp", "Rum Milk Punch", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a1e7b595-822d-4670-b93e-b06849b91a06"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vpqspv1478963339.jpg", "Dry Vermouth, Gin, Benedictine", "Stir all ingredients with ice, strain into a cocktail glass, and serve.", "1/2 oz, 1 1/2 oz, 1 1/2 tsp", "Queen Elizabeth", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d3991b52-9540-47bb-a872-cb6a9030eca2"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/sqxsxp1478820236.jpg", "Bourbon, Benedictine", "Pour the bourbon and Benedictine into a brandy snifter.", "2 oz, 1/2 oz", "Kentucky B And B", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("dc985a4c-5089-4b64-ad48-cf840bc4013d"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/5ia6j21504887829.jpg", "Gin, Grenadine, Light cream, Egg white", "Shake all ingredients with ice, strain into a cocktail glass, and serve.", "1 1/2 oz, 1 tsp, 1 tsp, 1", "Pink Lady", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("67b8559e-0474-4e5c-8216-797b26a1ddec"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vr6kle1504886114.jpg", "Creme de Cacao, Amaretto, Triple sec, Vodka, Light cream", "Shake all ingredients with ice, strain into a chilled cocktail glass, and serve.", "1/2 oz white, 1/2 oz, 1/2 oz, 1/2 oz, 1 oz", "Orgasm", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a7491fad-0c54-496b-afd2-759708a64e4f"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/20d63k1504885263.jpg", "Gin, Light cream, Powdered sugar, Lemon, Egg white, Carbonated water", "Shake all ingredients (except carbonated water) with ice and strain into a cocktail glass over two ice cubes. Fill with carbonated water, stir, and serve.", "2 oz, 2 tsp, 1 tsp, Juice of 1/2, 1", "Lady Love Fizz", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("2129fd34-1800-4742-a9c6-3be223c3161e"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/rpvtpr1468923881.jpg", "Scotch, Drambuie, Dry Vermouth, Lemon peel", "In a mixing glass half-filled with ice cubes, combine the Scotch, Drambuie, and vermouth. Stir well. Strain into a cocktail glass. Garnish with the lemon twist.", "2 oz, 1/2 oz, 1/2 oz, 1 twist of", "Loch Lomond", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("38ef0419-f439-40c0-8336-831a8ff25306"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/rpsrqv1468923507.jpg", "Gin, Maraschino liqueur, Orange bitters", "In a mixing glass half-filled with ice cubes, combine all of the ingredients. Stir well. Strain into a cocktail glass.", "1 1/2 oz, 1/2 oz, 2 dashes", "London Town", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c9aa825a-403a-4da7-b6a2-63b680d86a9b"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/tsxpty1468923417.jpg", "Sweet Vermouth, Gin", "Stir ingredients with ice, strain into a cocktail glass, and serve.", "3/4 oz, 1 1/2 oz", "Lone Tree Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("3522c686-04ab-429a-b5c5-3fcced702dc4"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/wsyqry1479298485.jpg", "Carbonated water, Gin, Dry Vermouth, Powdered sugar, Orange spiral, Lemon peel", "Stir powdered sugar and 2 oz. carbonated water in a collins glass. Fill glass with ice, add gin and vermouth, and stir. Fill with carbonated water and stir again. Add the twist of lemon peel and the orange spiral so that the end dangles over rim of glass.", "", "Lone Tree Cooler", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4c13d827-8338-4a10-a619-8aa05e458f15"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/quwrys1468923219.jpg", "Dark rum, Tia maria", "Pour the rum and Tia Maria into an old-fashioned glass almost filled with ice cubes. Stir well.", "1 1/2 oz, 1/2 oz", "Lord And Lady", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("dcc1ed45-bfab-49fa-b45d-c922d23258ed"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/qyr51e1504888618.jpg", "Bitters, Gin", "Pour the bitters into a wine glass. Swirl the glass to coat the inside with the bitters, shake out the excess. Pour the gin into the glass. Do not add ice.", "3 dashes, 2 oz", "Pink Gin", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("fbce566e-b475-4954-bda6-ff4f09b989f9"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/twyrrp1439907470.jpg", "Light rum, Orgeat syrup, Triple sec, Sweet and sour, Cherry", "Shake all ingredients with ice. Strain into glass. Garnish and serve with straw.", "1 oz, 1/2 oz, 1/2 oz, 1 1/2 oz, 1", "Mai Tai", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("54759ad8-ff8e-4c84-9537-03e479f325d3"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/71t8581504353095.jpg", "Gin, Dry Vermouth, Olive", "Straight: Pour all ingredients into mixing glass with ice cubes. Stir well. Strain in chilled martini cocktail glass. Squeeze oil from lemon peel onto the drink, or garnish with olive.", "1 2/3 oz, 1/3 oz, 1", "Martini", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("3cde206b-c62d-4158-a731-7e56895d11d2"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vsxxwy1441208133.jpg", "Bourbon, Dark rum, Heavy cream", "In a shaker half-filled with ice cubes, combine all of the ingredients. Shake well. Strain into a cocktail glass.", "2 oz, 1 oz, 1/2 oz", "Midnight Cowboy", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("9dd9416d-82f4-4ecb-909e-0b6c7ed9edfc"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/urpyqs1439907531.jpg", "Brandy, Light rum, Bourbon, Lemon, Powdered sugar, Carbonated water", "Shake all ingredients (except carbonated water) with ice and strain into a collins glass over ice cubes. Fill with carbonated water, stir, and serve.", "1 oz, 1/2 oz, 1/2 oz, Juice of 1/2, 1 tblsp", "Mississippi Planters Punch", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("82c0e65a-9b35-4b89-b5ff-c428d36f286a"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/8it05n1504353314.jpg", "Light rum, Grapefruit juice, Bitters", "Pour all of the ingredients into an old-fashioned glass almost filled with ice cubes. Stir well.", "1 1/2 oz, 3 oz, 1 dash", "Monkey Wrench", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("bbfceb99-f296-437a-ada3-30dfed330bd8"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/61wgch1504882795.jpg", "Blended whiskey, Lemon, Sugar, Red wine, Lemon, Cherry", "Shake blended whiskey, juice of lemon, and powdered sugar with ice and strain into a whiskey sour glass. Float claret on top. Decorate with the half-slice of lemon and the cherry and serve.", "2 oz, Juice of 1/2, 1 tsp, (Claret)", "New York Sour", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("752e3cb7-ab26-430d-a8e0-c8bc98f5c7d2"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/xqqytq1441167923.jpg", "Cherry brandy, Gin, Orange juice, Ginger ale", "Shake brandy, gin, and orange juice with ice and strain into a highball glass over ice cubes. Fill with ginger ale, stir, and serve.", "1/2 oz, 1 1/2 oz, 4 oz", "Orange Oasis", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("227bc56f-984b-47b6-a7b0-e1f64679a8c6"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/wwxwvr1439906452.jpg", "Gin, Dry Vermouth, Triple sec, Orange bitters, Cherry", "Stir all ingredients (except cherry) with ice and strain into a cocktail glass. Top with the cherry and serve.", "1 oz, 1 oz, 1/4 tsp, 1 dash, 1", "Martinez Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4d4ef85c-885d-4f67-a547-7ff21823b053"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/otn2011504820649.jpg", "Light rum, 151 proof rum, Powdered sugar, Bitters, Water, Lime peel", "Stir powdered sugar, water, and bitters in an old-fashioned glass. When sugar has dissolved add ice cubes and light rum. Add the twist of lime peel, float 151 proof rum on top, and serve.", "1 1/2 oz, 1 tsp, 1/2 tsp, 1 dash, 1 tsp, Twist of", "Rum Old-fashioned", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("86c352f9-6e49-4243-aeec-8f918009bba3"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/dhvr7d1504519752.jpg", "Brandy, Gin, Sweet Vermouth, Carbonated water, Lemon peel", "Pour brandy, gin, and sweet vermouth into a highball glass over ice cubes. Fill with carbonated water. Add the twist of lemon peel, stir, and serve. (Ginger ale may be substituted for carbonated water, if preferred.)", "3/4 oz, 3/4 oz, 3/4 oz", "English Highball", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("059d3d98-ee74-409e-9c12-e813daef9267"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/typuyq1439456976.jpg", "Scotch, Dry Vermouth, Lemon peel", "In a mixing glass half-filled with ice cubes, combine the Scotch and vermouth. Stir well. Strain into a cocktail glass. Garnish with the lemon twist.", "2 1/2 oz, 1 1/2 tsp, 1 twist of", "Dry Rob Roy", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b1a92bc7-3ec3-4a6e-b18a-6828c1403e50"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/uwryxx1483387873.jpg", "Blended whiskey, Dry Vermouth, Pineapple juice", "Combine and shake all ingredients with ice, strain contents into a cocktail glass, and serve.", "1 1/2 oz, 1 oz, 1 oz", "Algonquin", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c0670b52-b9ad-41eb-b08d-8b66cc67825c"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/uwvyts1483387934.jpg", "Dry Vermouth, Bourbon, Blackberry brandy, Lemon juice, Lemon peel", "Shake all ingredients (except lemon peel) with ice and strain into a cocktail glass. Top with the twist of lemon peel and serve.", "1 oz, 1 oz, 1 1/2 tsp, 1 1/2 tsp, 1 twist of", "Allegheny", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("95b9b391-50aa-4588-a999-8c113c4ff8cc"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/qvprvp1483388104.jpg", "Dry Vermouth, Gin, Kummel", "Stir all ingredients with ice, strain contents into a cocktail glass, and serve.", "1 oz, 1 oz, 1/2 tsp", "Allies Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("beb95e81-b0e6-4252-9d9d-b165cd02be74"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/rwsyyu1483388181.jpg", "Dark rum, Kahlua, Egg white", "In a shaker half-filled with ice cubes, combine all of the ingredients. Shake well. Strain into a cocktail glass.", "2 oz, 1 oz, 1", "Almeria", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("9691b9a4-3e31-4ccb-88bc-7598a8323c9f"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/xutuqs1483388296.jpg", "Amaretto, Creme de Cacao, Light cream", "Shake all ingredients with ice, strain into a cocktail glass, and serve.", "1/2 oz, 1/2 oz white, 2 oz", "Almond Joy", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c1937f66-93a3-4069-98b6-7eb95d37ddd7"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/dj8n0r1504375018.jpg", "Amaretto, Light cream", "Shake well with cracked ice, strain contents into a cocktail glass, and serve.", "1 1/2 oz, 1 1/2 oz", "Amaretto And Cream", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("52e4587f-f01b-4bd9-bcf3-abd99987f4b5"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/ypxsqy1483387829.jpg", "Lemon vodka, Triple sec, Pineapple juice", "Combine and shake all ingredients with ice, strain into a cocktail glass, and serve.", "1 1/2 oz, 1 dash, 1 tblsp", "Alfie Cocktail", "Alcoholic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("2eb7e273-b7c6-4165-b0e5-f15015456f66"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/utpxxq1483388370.jpg", "Amaretto, Lime", "Pour amaretto in an old-fashioned glass over crushed ice. Add the wedge of lime and serve. (A wedge of lemon may be substituted for lime, if preferred.)", "1 1/2 oz, 1", "Amaretto Mist", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("668abd9e-5ca2-43d7-a285-5c7b227e3a08"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vvop4w1493069934.jpg", "Amaretto, White Creme de Menthe", "Shake ingredients well with cracked ice, strain into a cocktail glass, and serve.", "1 1/2 oz, 3/4 oz", "Amaretto Stinger", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("bf1743ef-88d7-45b7-8861-7f4eb6d82b00"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/b7qzo21493070167.jpg", "Tea, Amaretto, Whipped cream", "Pour hot tea into a pousse-cafe glass, using a spoon in glass to prevent cracking. Add amaretto, but do not stir. Top with chilled whipped cream and serve.", "6 oz hot, 2 oz, Chilled", "Amaretto Tea", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("9bb5106e-f75d-4f2c-9eac-37a355273ca5"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vqpptp1478253178.jpg", "Apricot brandy, Apple brandy, Gin", "Shake all ingredients with ice and strain contents into a cocktail glass.", "1/2 oz, 1/2 oz, 1 oz", "Angel Face", "IBA,Classic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("999c6283-5c14-4d15-b78a-6ad92fca1da8"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/sbffau1504389764.jpg", "Applejack, Triple sec, Lemon juice", "Shake all ingredients with ice, strain into a cocktail glass, and serve.", "1 oz, 1 oz, 1 oz", "Applecar", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f5c635ee-dc77-46bf-adf3-bebc45b8d548"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/146f251504389814.jpg", "Light rum, Apricot brandy, Triple sec, Lemon juice, Egg white, Orange", "In a shaker half-filled with ice cubes, combine the rum, apricot brandy, triple sec, lemon juice, and egg white. Shake well. Strain into an old-fashioned glass almost filled with ice cubes. Garnish with the orange slice.", "1 1/2 oz, 1 oz, 1 tsp, 1/2 oz, 1, 1", "Apricot Lady", "Cold" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a32a8db4-6712-4683-a16c-5e80a4bf8050"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/xpqwrt1441207307.jpg", "Gin, Wine, Benedictine, Lime", "In an old-fashioned glass almost filled with ice cubes, combine all of the ingredients. Stir well.", "2 oz, 1 oz Green Ginger, 1 tsp, 1", "Archbishop", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("42e7dad4-8dd2-4c72-b07b-b8ba30f1dd14"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/3jm41q1493069578.jpg", "Amaretto, Lime juice, Club soda", "Pour amaretto and lime juice over ice in a collins glass. Fill with club soda and serve.", "1 1/2 oz, 1/2 oz", "Amaretto Rose", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("1a82b43c-ee6c-41a6-839d-9cb8f584ffc6"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/wyrrwv1441207432.jpg", "Champagne, Green Creme de Menthe", "Put creme de menthe into a champagne flute. Fill with chilled champagne and serve.", "Chilled, 1 tsp", "Arise My Love", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("779d9c88-5c15-4191-9c8c-441f81b98845"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/tvqxvr1483387746.jpg", "Brandy, Creme de Cacao, Light cream, Nutmeg", "Shake all ingredients (except nutmeg) with ice and strain contents into a cocktail glass. Sprinkle nutmeg on top and serve.", "1 oz, 1 oz white, 1 oz", "Brandy Alexander", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b3eb19f0-681c-4c0d-a5d6-31b719e82291"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/wsyryt1483387720.jpg", "Orange bitters, Gin, Yellow Chartreuse, Lemon peel", "Stir all ingredients with ice, strain contents into a cocktail glass. Drop in a twist of lemon and serve.", "2 dashes, 1 1/2 oz, 3/4 oz, Twist of", "Alaska Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("65410d6a-0642-46cd-ac0a-85e6838d8301"), null, "Beer", "https://www.thecocktaildb.com/images/media/drink/rwpswp1454511017.jpg", "Ale, Guinness stout", "Fill pint glass half full with Bass. Next pour Guiness over a spoon slowly until glass is full. If done correctly the Guiness will stay on top and the Bass on bottom hence the name Black & Tan.", "1 part Bass pale, 1 part", "Black & Tan", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4a80d56e-28bd-4412-b78a-13ee8f5043c3"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/rxtqps1478251029.jpg", "Light rum, Lime, Sugar, Mint, Soda water", "Muddle mint leaves with sugar and lime juice. Add a splash of soda water and fill the glass with cracked ice. Pour the rum and top with soda water. Garnish and serve with straw.", "2-3 oz, Juice of 1, 2 tsp, 2-4", "Mojito", "IBA,ContemporaryClassic,Alcoholic,USA" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("07a0705f-267e-4dca-a08c-33fdf3b6a610"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/vrwquq1478252802.jpg", "Bourbon, Angostura bitters, Sugar, Water", "Place sugar cube in old fashioned glass and saturate with bitters, add a dash of plain water. Muddle until dissolved.\r\nFill the glass with ice cubes and add whiskey.\r\n\r\nGarnish with orange twist, and a cocktail cherry.", "4.5 cL, 2 dashes, 1 cube, dash", "Old Fashioned", "IBA,Classic,Alcoholic,Expensive" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a115685b-ce5a-4668-8ca2-397e7dc62a5b"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/ywxwqs1439906072.jpg", "Vodka, Light rum, Gin, Tequila, Lemon, Coca-Cola", "Combine all ingredients (except cola) and pour over ice in a highball glass. Add the splash of cola for color. Decorate with a slice of lemon and serve.", "1/2 oz, 1/2 oz, 1/2 oz, 1/2 oz, Juice of 1/2, 1 splash", "Long Island Tea", "Strong,Asia,StrongFlavor,Brunch,Vegetarian" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("e869db26-a2bb-4899-b418-5f5ea6bd205e"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/qgdu971561574065.jpg", "Gin, Campari, Sweet Vermouth", "Stir into glass over ice, garnish and serve.", "1 oz, 1 oz, 1 oz", "Negroni", "IBA,Classic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4827c04c-f332-4ab8-8a91-0bfbfac9eb08"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/zxd8v41576797287.jpg", "Blended whiskey, Lemon, Powdered sugar, Cherry, Lemon", "Shake with ice. Strain into chilled glass, garnish and serve. If served 'On the rocks', strain ingredients into old-fashioned glass filled with ice.", "2 oz, Juice of 1/2, 1/2 tsp, 1, 1/2 slice", "Whiskey Sour", "IBA,Classic,Alcoholic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("314ed7f0-eeb6-4d67-af05-b00e4ba4c522"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/urystu1478253039.jpg", "Gin, Creme de Cacao, Light cream, Nutmeg", "Shake all ingredients with ice and strain contents into a cocktail glass. Sprinkle nutmeg on top and serve.", "1/2 oz, 1/2 oz white, 2 oz", "Alexander", "IBA,Classic,Dairy" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("14e49005-c5d8-4a3d-9e4f-a66f3dbc40a6"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/9uqt9p1576519019.jpg", "Gin, Dry Vermouth, Olive", "Straight: Pour all ingredients into mixing glass with ice cubes. Stir well. Strain in chilled martini cocktail glass. Squeeze oil from lemon peel onto the drink, or garnish with olive.", "1 2/3 oz, 1/3 oz, 1", "Dry Martini", "IBA,Classic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("28456294-4182-4214-9660-ac0c1cbabf63"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/wpxpvu1439905379.jpg", "Tequila, Triple sec, Lime juice, Salt", "Rub the rim of the glass with the lime slice to make the salt stick to it. Take care to moisten only the outer rim and sprinkle the salt on it. The salt should present to the lips of the imbiber and never mix into the cocktail. Shake the other ingredients with ice, then carefully pour into the glass.", "1 1/2 oz, 1/2 oz, 1 oz", "Margarita", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("e497ab2a-11c3-422f-a043-642feb74d909"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/ec2jtz1504350429.jpg", "Sweet Vermouth, Bourbon, Angostura bitters, Ice, Maraschino cherry, Orange peel", "Stirred over ice, strained into a chilled glass, garnished, and served up.", "3/4 oz, 2 1/2 oz Blended, dash, 2 or 3, 1, 1 twist of", "Manhattan", "IBA,Classic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("be9147f0-bec5-4d52-a8fa-560ae70c9fb4"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/3pylqc1504370988.jpg", "Vodka, Lime juice, Ginger ale", "Combine vodka and ginger beer in a highball glass filled with ice. Add lime juice. Stir gently. Garnish.", "2 oz, 2 oz, 8 oz", "Moscow Mule", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5dd5bd02-92f8-4abd-a17d-a001e22ff197"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vtytxq1483387578.jpg", "Apricot brandy, Triple sec, Lime, Lime", "Shake all ingredients (except lime wedge) with ice and strain into a cocktail glass. Add the wedge of lime and serve.", "1 oz, 1 oz, Juice of 1, 1", "After Dinner Cocktail", "DinnerParty" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("72fa79f3-5bd7-4555-bb31-fb24fbb24058"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/quyxwu1483387610.jpg", "Triple sec, Apricot brandy, Lemon juice", "Shake all ingredients with ice, strain into a cocktail glass, and serve.", "1 oz, 1 oz, 1/2 tsp", "After Supper Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("0bd8ffa0-9d26-4dbc-acca-af0938edf5c8"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/qtwxwr1483387647.jpg", "Southern Comfort, Amaretto, Sloe gin, Lemon juice", "Pour all ingredients (except for lemon juice) over ice in a highball glass. Stir, add a dash of lemon juice, and serve.", "1 oz, 1 oz, 1/2 oz, 1 dash", "Alabama Slammer", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f3fbd20c-c874-4741-8dfa-7731c9e07176"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/usuuur1439906797.jpg", "Light rum, Lime, Powdered sugar", "Pour all ingredients into shaker with ice cubes. Shake well. Strain in chilled cocktail glass.", "1 1/2 oz, Juice of 1/2, 1 tsp", "Daiquiri", "IBA,Classic,Beach" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("afe05dfe-b366-4dfd-8db6-283527962635"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/xxsuwr1439457147.jpg", "Dubonnet Rouge, Gin, Bitters, Lemon peel", "Stir all ingredients (except lemon peel) with ice and strain into a cocktail glass. Add the twist of lemon peel and serve.", "1 1/2 oz, 3/4 oz, 1 dash, 1 twist of", "Dubonnet Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d2258252-d998-49ea-9743-f0d27193260c"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/7onfhz1493067921.jpg", "Gin, Grand Marnier, Lemon juice, Lemon peel", "In a shaker half-filled with ice cubes, combine the gin, Grand Marnier, and lemon juice. Shake well. Strain into a sour glass and garnish with the lemon twist.", "2 oz, 1/2 oz, 2 tsp, 1 twist of", "Arthur Tompkins", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d9d378a6-8af0-458e-a4e4-4b538bf9e691"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vysuyq1441206297.jpg", "Scotch, Sweet Vermouth, Dry Vermouth, Bitters", "In a mixing glass half-filled with ice cubes, combine all of the ingredients. Stir well. Strain into a cocktail glass.", "1 1/2 oz, 1/2 oz, 1/2 oz, 2 dashes", "Balmoral", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d4263e4d-0801-4c51-92bd-4844bd4fd7b0"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vtvutr1439465836.jpg", "Sugar, Club soda, Lemon, Brandy, Maraschino cherry, Orange", "In an old-fashioned glass, dissolve the sugar in the club soda. Add crushed ice until the glass is almost full. Add the brandy. Stir well. Garnish with the cherry and the orange and lemon slices.", "1 tsp superfine, 3 oz, 1, 2 oz, 1, 1", "Brandy Cobbler", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("0af02793-6f65-4f36-836e-2aee5498207a"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/tu0mts1504366540.jpg", "Brandy, Lemon, Powdered sugar, Lemon, Cherry", "Shake brandy, juice of lemon, and powdered sugar with ice and strain into a whiskey sour glass. Decorate with the lemon slice, top with the cherry, and serve.", "2 oz, Juice of 1/2, 1/2 tsp, 1/2 slice, 1", "Brandy Sour", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4a21227a-e651-4237-99d3-7b9c724b5c93"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/xyrppt1469090521.jpg", "Sugar, Lime, Cachaca", "Place lime and sugar into old fashioned glass and muddle (mash the two ingredients together using a muddler or a wooden spoon). Fill the glass with ice and add the Cacha�a.", "2 tsp, 1, 2 1/2 oz", "Caipirinha", "ContemporaryClassic,IBA" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b6898344-b066-4e6f-a299-ae5f2015f8ea"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/qvvxwy1472406424.jpg", "Blended whiskey, Lemon, Lime, Powdered sugar, Grenadine, Carbonated water", "Shake all ingredients (except carbonated water) with ice and strain into a collins glass over shaved ice. Fill with carbonated water and stir. Decorate with slices of orange and lemon. Add the cherry and serve with a straw.", "2 oz, Juice of 1, Juice of 1, 1 tblsp, 1/4 tsp", "California Lemonade", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("280265e2-e27f-40a3-8812-80196e662ca8"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/usspxq1441553762.jpg", "Light rum, Triple sec, Lime juice, Maraschino liqueur", "Shake all ingredients with ice, strain into a cocktail glass, and serve.", "2 oz, 1 1/2 tsp, 1 1/2 tsp, 1 1/2 tsp", "Casa Blanca", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d10cf5db-a59e-4956-afc2-1f88d1455332"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/3qpv121504366699.jpg", "Gin, Lemon juice, Maraschino liqueur, Orange bitters, Egg yolk", "In a shaker half-filled with ice cubes, combine all of the ingredients. Shake well. Strain into a sour glass.", "2 oz, 1/2 oz, 1 tsp, 1 dash, 1", "Casino Royale", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d85f5ffc-c133-413e-8cd4-17fa96905245"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/pwgtpa1504366376.jpg", "Gin, Triple sec, Lemon juice, Grenadine, Egg white", "In a shaker half-filled with ice cubes, combine all of the ingredients. Shake well. Strain into a sour glass.", "1 1/2 oz, 1 oz, 1 tsp, 1/2 tsp, 1", "Boxcar", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("84c02e64-2639-4472-84ce-71517041c96d"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/ehh5df1504366811.jpg", "Champagne, Sugar, Bitters, Lemon peel, Cognac", "Add dash of Angostura bitter onto sugar cube and drop it into champagne flute. Add cognac followed by gently pouring chilled champagne. Garnish with orange slice and maraschino cherry.", "Chilled, 1 piece, 2 dashes, 1 twist of, 1 dash", "Champagne Cocktail", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("990b0190-781c-4260-b7c7-7595f92a4104"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/qwvwqr1441207763.jpg", "Light rum, Port, Lemon, Powdered sugar, Egg white, Carbonated water", "Shake all ingredients (except carbonated water) with ice and strain into a highball glass over two ice cubes. Fill with carbonated water, stir, and serve.", "1 oz, 1 oz, Juice of 1/2, 1 tsp, 1", "Chicago Fizz", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("ec702999-3150-4080-a833-f34e324906c2"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/yyvywx1472720879.jpg", "Kahlua, Vodka, Chocolate ice-cream", "Combine all ingredients in an electric blender and blend at a low speed for a short length of time. Pour into a chilled champagne flute and serve.", "1 oz, 1/2 oz, 5 oz", "Chocolate Black Russian", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("99ea0f76-76b4-4816-b73c-cc9fd3cfb08b"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/dazdlg1504366949.jpg", "Brandy, Triple sec, Lemon juice", "In a shaker half-filled with ice cubes, combine all of the ingredients. Shake well. Strain into a cocktail glass.", "2 oz, 1/2 oz, 1 tblsp", "City Slicker", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b79a6006-b412-428a-90e8-1d5f7fe598c3"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/qxvtst1461867579.jpg", "Sweet Vermouth, Sloe gin, Wine", "Stir all ingredients with ice, strain into a cocktail glass, and serve.", "1 oz, 1/2 oz, 1/2 oz Muscatel", "Clove Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("0cdb4d9a-f7d0-4eba-84cd-dcf47272df00"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/uuxsrr1473201663.jpg", "Light rum, Lime, Coca-Cola", "Build all ingredients in a Collins glass filled with ice. Garnish with lime wedge.", "2 oz, Juice of 1/2", "Cuba Libre", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7fee8ce7-5c51-48c1-aa50-4a23f9429941"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/lnvbip1504389100.jpg", "Gin, Ginger ale, Lime", "In a highball glass almost filled with ice cubes, combine the gin and ginger ale. Stir well. Garnish with the lime wedge.", "1 1/2 oz, 4 oz, 1", "Dragonfly", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c72e7162-2d41-4976-a9a4-71ca4b585b53"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/twsuvr1441554424.jpg", "Light rum, Cherry brandy, Light cream", "Shake all ingredients with ice, strain into a cocktail glass, and serve.", "1 1/4 oz, 1 1/2 tsp, 1 tblsp", "Cherry Rum", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c7112cb5-84ba-46c8-9675-aff617b2a0e0"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/g1vnbe1493067747.jpg", "Sweet Vermouth, Gin, Bitters", "Stir all ingredients with ice, strain into a cocktail glass, and serve.", "1 1/2 tsp, 1 1/2 oz, 2 dashes", "Artillery", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("3aa33eca-aa92-4e30-b6e6-be4e0b4fe071"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/dms3io1504366318.jpg", "Bourbon, Lemon juice, Sugar, Orange, Maraschino cherry", "In a shaker half-filled with ice cubes, combine the bourbon, lemon juice, and sugar. Shake well. Strain into a whiskey sour glass, garnish with the orange slice and cherry.", "2 oz, 1 oz, 1/2 tsp superfine, 1, 1", "Bourbon Sour", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("991f0723-4c34-494d-b481-7df0a672a989"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/anhof61504366173.jpg", "Bitters, Water, Sugar, Bourbon, Orange, Maraschino cherry", "In an old-fashioned glass, muddle the bitters and water into the sugar cube, using the back of a teaspoon. Almost fill the glass with ice cubes and add the bourbon. Garnish with the orange slice and the cherry. Serve with a swizzle stick.", "3 dashes, 1 tsp, 1, 3 oz, 1, 1", "Classic Old-Fashioned", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("1025189d-09dd-467b-9202-9eb945634564"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/k1xatq1504389300.jpg", "Light rum, Triple sec, Banana, Lime juice, Sugar, Cherry", "Pour all ingredients into shaker with ice cubes. Shake well. Strain in chilled cocktail glass.", "1 1/2 oz, 1 tblsp, 1, 1 1/2 oz, 1 tsp, 1", "Banana Daiquiri", "Fruity" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("ab82f2aa-68d9-4e29-bb15-4e00c648410e"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/qrvtww1441206528.jpg", "Brandy, Gin, Dry Vermouth, Carbonated water, Lemon peel", "Pour brandy, gin, and dry vermouth into a highball glass over ice cubes. Fill with carbonated water and stir. Add the twist of lemon and serve. (Ginger ale may be substituted for carbonated water, if preferred.)", "3/4 oz, 3/4 oz, 3/4 oz", "Bermuda Highball", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("6f359101-11ae-475d-b127-332ce137c2bc"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/2k5gbb1504367689.jpg", "Coffee liqueur, Vodka", "Pour the ingredients into an old fashioned glass filled with ice cubes. Stir gently.", "3/4 oz, 1 1/2 oz", "Black Russian", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("241dbde9-c9d5-46a1-868c-48840692abdb"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/xvswvy1441209430.jpg", "Sweet Vermouth, Sloe gin, Lemon peel", "Stir sloe gin and vermouth with ice and strain into a cocktail glass. Add the twist of lemon peel and serve.", "1 oz, 1 1/2 oz, 1 twist of", "Blackthorn", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("ee5e56b4-54f0-4952-9305-aecf13dac74a"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/yz0j6z1504389461.jpg", "Tequila, Tomato juice, Lemon juice, Tabasco sauce, Celery salt, Lemon", "Shake all ingredients (except lemon slice) with cracked ice and strain into an old-fashioned glass over ice cubes. Add the slice of lemon and serve.", "1 oz, 2 oz, 1 dash, 1 dash, 1 dash, 1 slice", "Bloody Maria", "Breakfast,Brunch,Hangover" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("2a392fda-ed89-4337-a130-c2706465aa13"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/uyquuu1439906954.jpg", "Vodka, Tomato juice, Lemon juice, Worcestershire sauce, Tabasco sauce, Lime", "Stirring gently, pour all ingredients into highball glass. Garnish.", "1 1/2 oz, 3 oz, 1 dash, 1/2 tsp, 2-3 drops, 1 wedge", "Bloody Mary", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("3c2e6780-0325-49f8-995e-2f40fa4032f7"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/3s36ql1504366260.jpg", "Sugar, Water, Lemon juice, Bourbon, Lemon peel", "In a shaker half-filled with ice cubes, combine the sugar, water, lemon juice, and bourbon. Shake well. Strain well. Strain into a highball glass. Garnish with the lemon twist.", "1 tsp superfine, 2 tsp, 1 oz, 2 oz, 1 twist of", "Bourbon Sling", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("ccc120bc-1a30-4a29-8406-1b749f2119af"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vak0e51504389504.jpg", "Vodka, Blue Curacao, Lemonade, Cherry", "Pour vodka and curacao over ice in a highball glass. Fill with lemonade, top with the cherry, and serve.", "1 oz, 1 oz", "Blue Lagoon", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4548fabd-2b08-46fe-9dd1-d59e7e2c41c3"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vsxssp1441209853.jpg", "A�ejo rum, Tia maria, Vodka, Orange juice, Lemon juice", "In a shaker half-filled with ice cubes, combine all of the ingredients. Shake well. Strain into an old-fashioned glass alomst filled with ice cubes.", "1 1/2 oz, 1/2 oz, 1/2 oz, 1 oz, 1 tsp", "Blue Mountain", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c99b7b5f-3a42-40a0-b034-2a6e77443ae4"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vxypsq1441209971.jpg", "Gin, Triple sec, Blue Curacao, Bitters, Maraschino cherry, Lemon peel", "In a mixing glass half-filled with crushed ice, combine the gin, triple sec, Curacao, and bitters. Stir well. Strain into a cocktail glass and garnish with the lemon twist and the cherry.", "1 1/2 oz, 1/2 oz, 1/2 oz, 2 dashes, 1, 1 twist of", "Bluebird", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("8bd1b420-5f52-488b-a0a8-e7cad85923c9"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/km6se51484411608.jpg", "Sweet Vermouth, Scotch, Benedictine, Lemon peel", "Stir all ingredients (except lemon peel) with ice and strain into a cocktail glass. Add the twist of lemon peel and serve.", "1 1/2 oz, 1 1/2 oz, 1 1/4 tsp, 1 twist of", "Bobby Burns Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b86fc043-9b0f-4af4-8167-4a65ac5e485d"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/3m6yz81504389551.jpg", "Gin, Dry Vermouth, Bitters, Maraschino liqueur, Maraschino cherry", "In a mixing glass half-filled with ice cubes, combine the gin, vermouth, bitters, and maraschino liqueur. Stir well. Strain into a cocktail glass and garnish with the cherry.", "2 oz, 1/2 oz, 2 dashes, 1/2 tsp, 1", "Boomerang", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("16144781-edc5-4fc8-bf63-efa392bcd722"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/qzs5d11504365962.jpg", "Light rum, Brandy, Triple sec, Lime", "Shake all ingredients with ice, strain into a cocktail glass, and serve.", "3/4 oz, 3/4 oz, 3/4 oz, Juice of 1/2", "Boston Sidecar", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("074d9135-ecb6-4954-8a2c-c0c75ee96779"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/kxlgbi1504366100.jpg", "Blended whiskey, Lemon, Powdered sugar, Egg white, Lemon, Cherry", "Shake juice of lemon, powdered sugar, blended whiskey, and egg white with cracked ice and strain into a whiskey sour glass. Add the slice of lemon, top with the cherry, and serve.", "2 oz, Juice of 1/2, 1 tsp, 1, 1 slice, 1", "Boston Sour", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("e30a3c91-592b-48ac-93c8-a2f75893a515"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/qtvvyq1439905913.jpg", "Tequila, Blue Curacao, Lime juice, Salt", "Rub rim of cocktail glass with lime juice. Dip rim in coarse salt. Shake tequila, blue curacao, and lime juice with ice, strain into the salt-rimmed glass, and serve.", "1 1/2 oz, 1 oz, 1 oz, Coarse", "Blue Margarita", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("000ad63a-b5d6-4793-b777-a363ef482d3b"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/4c85zq1511782093.jpg", "Light rum, Orange juice", "Pour rum into a highball glass over ice cubes. Add orange juice, stir, and serve.", "1 1/2 oz, 5 oz", "Rum Screwdriver", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("13e93393-9f75-4bf6-ad0b-7f29c83ff752"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/6ty09d1504366461.jpg", "Brandy, Egg, Sugar, Light cream, Nutmeg", "In a shaker half-filled with ice cubes, combine the brandy, egg, sugar, and cream. Shake well. Strain into a sour glass and garnish with the nutmeg.", "2 oz, 1 whole, 1 tsp superfine, 1/2 oz, 1/8 tsp grated", "Brandy Flip", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("1a28642a-1287-4def-affe-6fb4a57f0327"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/athdk71504886286.jpg", "Rum, Powdered sugar, Lemon peel, Water", "Dissolve powdered sugar in water in an old-fashioned glass. Add rum and one ice cube and stir. Add the twist of lemon peel and serve.", "2 oz light or dark, 2 tsp, 1 twist of, 2 tsp", "Rum Toddy", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f575020f-6f47-4e13-b6a9-442cdecca6a0"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/isql6y1487602375.jpg", "Coffee, Cinnamon", "Incidentally, a pinch of cinnamon is indeed a nice addition to coffee but true heaven is a cardamom seed. Of course, you serve it in a coffee mug.", "", "Spiking coffee", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4040373c-b8e0-462d-badc-c65fdbe38a1f"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/wquwxs1441247025.jpg", "Coffee, Coriander, Cardamom, Sugar, Whipping cream, Ice", "Place the coffee and spices in the filter cone of your coffee maker. Brew coffee as usual, let it cool. In a tall glass, dissolve 1 or 2 teaspoons of sugar in an ounce of the coffee (it's easier to dissolve than if you put it right over ice). Add 5-6 ice cubes and pour coffee to within about 1 inch of the top of the glass. Rest a spoon on top of the coffee and slowly pour whipping cream into the spoon. This will make the cream float on top of the coffee rather than dispersing into it right away.", "6 tblsp ground, 1/4 tsp, 4-5 whole green", "Thai Coffee", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("9ad4a12c-8d1e-439f-bb01-7b7e7b73d4d7"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/rqpypv1441245650.jpg", "Coffee, Sugar, Cream, Cardamom", "Prepare a pot of coffee at a good European strength. In the ground coffee, add 2 or 3 freshly ground cardamom pods. Sweeten while hot, then cool quickly. Serve in highball glass over ice, with cream. To get the layered effect, place a spoon atop the coffee and pour the milk carefully into the spoon so that it floats on the top of the coffee.", "black, pods", "Thai Iced Coffee", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("338a2a45-831f-4ac0-97de-1c4c8b7af467"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/trvwpu1441245568.jpg", "Tea, Water, Condensed milk, Ice, Mint", "Combine Thai tea (i.e., the powder), boiling water, and sweetened condensed milk, stir until blended. Pour into 2 tall glasses filled with ice cubes. Garnish with mint leaves. Makes 2 servings.", "1/4 cup Thai, 1/2 cup boiling, 2 tsp sweetened, cubes", "Thai Iced Tea", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("19ce12e1-bb10-4929-8072-7944655b1ae6"), null, "Homemade Liqueur", "https://www.thecocktaildb.com/images/media/drink/uxxtrt1472667197.jpg", "Vodka, Sugar, Anise, Licorice root, Wormwood", "Mix together and let sit a few days. Strain through a coffee filter. To serve mix 1 part absinthe to 4 parts water, add ice, enjoy.", "1 bottle, 50 gr, 50 ml pure, 1 tblsp, 1", "Absinthe #2", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4c94b635-fbab-4271-9725-12085293760d"), null, "Homemade Liqueur", "https://www.thecocktaildb.com/images/media/drink/swqxuv1472719649.jpg", "Sugar, Water, Apricot, Almond flavoring, Grain alcohol, Water, Brandy, Food coloring, Food coloring, Food coloring, Glycerine", "Combine sugar and 3/4 cup water in a small saucepan. Bring to a boil, stirring constantly. Reduce heat and simmer until all sugar is dissolved. Remove from heat and cool. In an aging container, combine apricot halves, almond extract, grain alcohol with 1/2 cup water, and brandy. Stir in cooled sugar syrup mixture. Cap and let age for 2 days. Remove apricot halves. (Save apricot halves, can be used for cooking). Add food coloring and glycerine. Stir, recap and continue aging for 1 to 2 months. Re-bottle as desired. Liqueur is ready to serve but will continue to improve with additional aging.", "1 cup, 3/4 cup, 2, 1 tblsp, 1/2 cup pure, 1/2 cup, 1 cup, 3 drops yellow, 6 drops red, 2 drops blue, 1/2 tsp", "Amaretto Liqueur", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("dacf3803-e3d3-466f-8d71-fbb17bb5a808"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/xwtptq1441247579.jpg", "Espresso, Honey, Cocoa powder", "Brew espresso. In a coffee mug, place 1 teaspoon of unsweetened powdered cocoa, then cover a teaspoon with honey and drizzle it into the cup. Stir while the coffee brews, this is the fun part. The cocoa seems to coat the honey without mixing, so you get a dusty, sticky mass that looks as though it will never mix. Then all at once, presto! It looks like dark chocolate sauce. Pour hot espresso over the honey, stirring to dissolve. Serve with cream.", "Unsweetened", "Melya", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("3c6474ba-3f57-4e10-9495-6f74906b1fc0"), null, "Homemade Liqueur", "https://www.thecocktaildb.com/images/media/drink/yuurps1472667672.jpg", "Angelica root, Almond, Allspice, Cinnamon, Anise, Coriander, Marjoram leaves, Vodka, Sugar, Water, Food coloring, Food coloring", "Combine all herbs, nuts and spices with vodka in a 1 quart or larger aging container. Cap tightly and shake daily for 2 weeks. Strain through a fine muslin cloth or coffee filter, discarding solids. Clean out aging container. Place liquid back in container. Place sugar and water in saucepan and stir to combine over medium heat. When sugar is completely dissolved, set aside and let cool. When cool combine with food coloring and add to liqueur liquid. Cap and allow to age and mellow in a cool, dark place for one month.", "3 tblsp chopped, 1 tblsp chopped, 1 cracked, 1 one-inch, 3-6 crushed, 1/8 tsp powdered, 1 tblsp fresh chopped, 1.5 cup, 1/2 cup granulated, 1/4 cup, 1 drop yellow, 1 drop green", "Angelica Liqueur", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("15523a52-26b4-41c7-91b9-5bdcabe8d275"), null, "Homemade Liqueur", "https://www.thecocktaildb.com/images/media/drink/ryvtsu1441253851.jpg", "Coffee, Vanilla extract, Sugar, Vodka, Water", "Combine coffee, sugar and water. Simmer 1 hour and let cool. Add vanilla and vodka. Age in sealed jar 2 to 3 weeks.", "10 tblsp instant, 4 tblsp, 2 1/2 cups, 1 qt, 2 1/2 cups", "Coffee Liqueur", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("da89dccb-d150-4b44-be85-fd9f71b49c5c"), null, "Homemade Liqueur", "https://www.thecocktaildb.com/images/media/drink/qvrrvu1472667494.jpg", "Water, Sugar, Coffee, Vanilla, Vodka, Caramel coloring", "Boil water and sugar until dissolved. Turn off heat. Slowly add dry instant coffee and continue stirring. Add a chopped vanilla bean to the vodka, then combine the cooled sugar syrup and coffee solution with the vodka. Cover tightly and shake vigorously each day for 3 weeks. Strain and filter. Its also best to let the sugar mixture cool completely so the vodka won't evaporate when its added. If you like a smoother feel to the liqueur you can add about 1 teaspoon of glycerine to the finished product.", "2 cups, 2 cups white, 1/2 cup instant, 1/2, 1 1/2 cup", "Coffee-Vodka", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("21f8b29f-cde0-4d10-be83-c8819d1dd742"), null, "Homemade Liqueur", "https://www.thecocktaildb.com/images/media/drink/qtspsx1472667392.jpg", "Cranberries, Sugar, Light rum", "Place the chopped cranberries in a 2 liter jar that has a tight-fitting lid. Add the sugar and rum. Adjust the lid securely and place the jar in a cool, dark place. Invert the jar and shake it every day for six weeks. Strain the cordial into bottles and seal with corks.", "1/2 kg chopped, 3/4 L, 1/2 L", "Cranberry Cordial", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("16f08350-0d50-4b63-b8bc-e75b5f695085"), null, "Homemade Liqueur", "https://www.thecocktaildb.com/images/media/drink/yxswtp1441253918.jpg", "Sugar, Water, Grain alcohol, Peppermint extract, Food coloring", "Bring sugar and water to a boil and simmer for 10 minutes. Cool. Add the remaining ingredients and stir. Cover and let ripen for 1 month.", "8 cups, 6 cups, 1 pint, 1 oz pure, 1 tblsp green", "Creme de Menthe", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5e53770c-03b4-4ec6-b88d-acca2687969e"), null, "Homemade Liqueur", "https://www.thecocktaildb.com/images/media/drink/90etyl1504884699.jpg", "Scotch, Half-and-half, Condensed milk, Coconut syrup, Chocolate syrup", "Mix scotch and milk. Add half-and-half. Add rest.", "1 cup, 1 1/4 cup, 1 can sweetened, 3 drops, 1 tblsp", "Irish Cream", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("9098d291-9730-4867-b016-b634dee12dc5"), null, "Homemade Liqueur", "https://www.thecocktaildb.com/images/media/drink/upqvvp1441253441.jpg", "Johnnie Walker, Honey, Angelica root, Fennel seeds, Lemon peel", "Combine all ingreds in aging container. Cover tightly and shake gently several times during the first 24 hrs. After 24 hrs, remove the lemon zest. Cover again and let stand in a cool, dark place for 2 weeks, shaking gently every other day. Strain through a wire sieve to remove the angelica root and fennel. Return to aging container, cover and let stand undisturbed in a cool dark place for 6 months. Siphon or pour clear liqueur into a sterile bottle. The cloudy dregs may be saved for cooking.", "1 fifth, 1 1/2 cup mild, 2 tsp dried and chopped, 1/4 tsp crushed, 2 2 inch strips", "Scottish Highland Liqueur", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("2d4ae48a-8642-4362-bccb-b64f5222df57"), null, "Homemade Liqueur", "https://www.thecocktaildb.com/images/media/drink/qwxuwy1472667570.jpg", "Orange, Vodka, Sugar", "Pare very thinly the bright-colored rind from the oranges (no white). Blot the peel on paper towels to remove any excess oil. Put peel in a 4 cup screw-top jar. Add 2 cups vodka. Close jar. Store in a cool, dark place for 2 days or until the vodka has absorbed the flavor. Remove peel and add remaining vodka. Close jar and add remaining cup of vodka. Close the jar and store in a cool dark place at least 1 month to age.", "3 large, 3 cups, 1 1/3 cup superfine", "Caribbean Orange Liqueur", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d9119774-0cdf-4438-8a2f-9b9005538e29"), null, "Homemade Liqueur", "https://www.thecocktaildb.com/images/media/drink/sih81u1504367097.jpg", "Water, Brown sugar, Coffee, Rum, Vanilla extract", "Boil water, sugar and coffe for 10 mins and let cool. Add rum and vanilla. Put in clean bottle(s) and leave for 1 week before using.", "1 cup, 3/4-1 cup, 4 tsp, 1 cup, 4 tsp", "Tia-Maria", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("80706307-471f-419d-8461-478c50ef8ae3"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/uyrpww1441246384.jpg", "Water, Tea, Ginger, Cardamom, Cloves, Cinnamon, Black pepper, Sugar, Milk", "Bring 2 cups of water to boil. Add all the ingredients and boil again for about 15 seconds. Let stand for a minute. Warm milk in a pot. Filter tea into cups. Add milk and sugar. That's IT.", "2 cups, 3-4 tsp, 1 chunk dried, 3-4 crushed, 3, 1 piece, 1-2 whole, to taste", "Masala Chai", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b9a689db-4d8c-466e-a738-9aa77a56c71c"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/ytprxy1454513855.jpg", "Coffee, Sugar, Water, Milk", "Mix together until coffee and sugar is dissolved. Add milk. Shake well. Using a blender or milk shake maker produces a very foamy drink. Serve in coffee mug.", "1/4 cup instant, 1/4 cup, 1/4 cup hot, 4 cups cold", "Iced Coffee", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("58f0d796-b7d4-4664-af81-0fdaff656032"), null, "Cocoa", "https://www.thecocktaildb.com/images/media/drink/0lrmjp1487603166.jpg", "Chocolate, Butter, Vanilla extract, Half-and-half, Marshmallows", "Melt the chocolate, butter and vanilla in a double boiler. When just smooth stir in the cream.", "12 oz fine, 1 tsp, 1/2 tsp, 1 cup, mini", "Hot Chocolate to Die for", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("8bb3b090-471d-4ae1-8445-1597bf145c37"), null, "Cocoa", "https://www.thecocktaildb.com/images/media/drink/8y4x5f1487603151.jpg", "Sugar, Cocoa powder, Salt, Water, Milk, Vanilla extract", "Combine sugar, cocoa, salt and hot water in 1-quart micro-proof measuring cup (or coffee mug). Microwave at HIGH (100%) for 1 to 1 1/2 minutes or until boiling. Add milk, sitr and microwave an additonal 1 1/2 to 2 minutes or until hot. Stir in vanilla, blend well.", "5 tblsp, 3 tblsp, 1 dash, 3 tblsp hot, 2 cups, 1/4 tsp", "Microwave Hot Cocoa", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("20d25042-f866-4c78-a5b6-1b4e5fdcb3e2"), null, "Cocoa", "https://www.thecocktaildb.com/images/media/drink/xcu6nb1487603142.jpg", "Cocoa powder, Sugar, Vanilla extract, Milk", "Mix with a bit of milk (1 oz or so) in coffee mug. Nuke mug for about 30-50 seconds. Stir until the heated cocoa dissolves. Fill mug with milk. Nuke for 1-2 minutes, depending on wattage and preferences as to burnt mouth parts.", "2 tsp, 1 tsp, 1/2 tsp, 12 oz", "Nuked Hot Chocolate", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5a4d944d-5c1d-42a9-9ec5-307c70cecd6a"), null, "Cocoa", "https://www.thecocktaildb.com/images/media/drink/hdzwrh1487603131.jpg", "Milk, Chocolate, Orange peel, Espresso, Nutmeg", "Combine all ingredients in heavy medium saucepan. Stir over low heat until chocolate melts. Increase heat and bring just to a boil, stirring often. Remove from heat and whisk untily frothy. Return to heat and bring to boil again. Remove from heat, whisk until frothy. Repeat heating and whisking once again. Discard orange peel. (Can be prepared 2 hours ahead. Let stand at room temperature. Before serving, bring just to boil, remove from heat and whisk until frothy.) Pour hot chocolate into coffee mugs. Makes 2 servings.", "2 cups, 4 oz chopped bittersweet or semi-sweet, 3 2-inch strips, 1/2 tsp instant, 1/8 tsp ground", "Orange Scented Hot Chocolate", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b70b9cd4-9506-4b1a-a6df-9e7dff48c02b"), null, "Cocoa", "https://www.thecocktaildb.com/images/media/drink/pra8vt1487603054.jpg", "Milk, Chocolate, Cinnamon, Egg yolk", "Stir the milk with the chocolate and the cinnamon over low heat until the chocolate dissolves. Add the eggs and beat the mixture until it becomes thick, taking care not to boil. Serve in coffee mug.", "2 cups, 2 oz sweet, 1/2 tsp, 2 beaten", "Spanish chocolate", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("1cc67952-a2d3-4156-a914-44facbd7d243"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/mx31hv1487602979.jpg", "Galliano, Absolut Citron, Lemon, Sugar, 151 proof rum", "Mix Galliano and Absolut Citron in a shot glass, lay lemon wedge sprinkled with sugar over glass and pour a rum over wedge and glass. light rum with a lighter and let burn for a second. Do shot quickly and suck on lemon. If it is done correctly, this will taste like a shot of sweet lemonade.", "1/2 oz, 1/2 oz, wedge, Bacardi", "Lemon Shot", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("216b0ac1-bd05-45f1-95a6-89642800ddfc"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/sxtxrp1454514223.jpg", "Kahlua, Coffee", "Mix together in a coffee mug and chill before serving.", "2 tsp, Strong cold", "Iced Coffee Fillip", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("213fa8bd-88dc-40ed-bc18-e3cbd49230c5"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/lijtw51551455287.jpg", "Vodka, Peach schnapps, Cranberry juice, Grapefruit juice", "Build all ingredients in a highball glass filled with ice. Garnish with orange slice.", "1 oz, 3/4 oz", "Sex on the Beach", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("3dd49a55-c0bb-480d-ba88-a448c1c5031f"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/lyloe91487602877.jpg", "Peach Vodka, Lemon juice, Galliano, Sirup of roses", "Shake well and serve in a cocktail glass. This is a home cocktail of American/Internet Bar del Pozzo, Pavia, Italy.", "5 parts, 3 parts, 1 part, 1 part", "Gagliardo", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("e194ee69-3bf0-4d70-853e-5f30568c1347"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/2rzfer1487602699.jpg", "Ouzo, Baileys irish cream, Gin, Grand Marnier", "Lots of ice and soda top up in tall glass with cherry and a grin.", "1 part, 1 part, 2 parts, 1/2 part", "Surf City Lifesaver", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c977be9e-1e39-4c6e-b59c-99bd1b852816"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/k6v97f1487602550.jpg", "Amaretto, J�germeister, Kahlua, Milk", "Served over ice. Sounds nasty, but tastes great.", "1 part, 1 part, 1 part, 2 1/2 parts", "Grizzly Bear", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b3f80e0e-66ba-4540-86f7-099aed91935d"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/808mxk1487602471.jpg", "Coffee, Grain alcohol", "Put a copper coin in a coffe-cup and fill up with coffee until you no longer see the coin, then add alcohol until you see the coin. Norwegian speciality.", "1 part, 2 parts", "Karsk", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("0476482b-6820-404f-b4b4-cf90f520bb81"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/42w2g41487602448.jpg", "Spiced rum, Ginger ale, Lime, Ice", "Pour Captain Morgan's Spiced Rum over ice, fill glass to top with Ginger Ale. Garnish with lime. Tastes like a cream soda. Named for the Gilligan's Island reference (\"The Captain\" *in* \"Ginger\" is a Happy Skipper!)", "1 1/2 cl", "Happy Skipper", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("94fae4d0-2fa2-44d3-802c-97e904a0ad19"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/vqwryq1441245927.jpg", "Coffee, Milk, Sugar", "Mix together. Blend at highest blender speed for about 1 minute. Pour into a glass and drink with a straw. Notes: This works best if everything is cold (if you make fresh coffee, mix it with the milk and let it sit in the fridge for 1/2 hour. If it is not frothy, add more milk, or even just some more milk powder. The froth gradually turns to liquid at the bottom of the glass, so you will find that you can sit and drink this for about 1/2 hour, with more iced coffee continually appearing at the bottom. Very refreshing.", "1/2 cup black, 1/2 cup, 1-2 tsp", "Frapp�", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("035ab040-f8da-47a9-b895-e2874e352c87"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/7dkf0i1487602928.jpg", "Vodka, Lime juice, Soda water", "Mix and fill up with soda water. Drunk by finns on a sunny day any time of the year and day.", "4 cl, 1 dash", "Autodaf�", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("fa354f5a-546b-4d61-92eb-99a18baa2310"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/wsyvrt1468876267.jpg", "Water, Ginger, Guava juice, Lemon juice, Pineapple, Sugar, Pineapple juice", "Add 1/4 cup water to ginger root. Boil 3 minutes. Strain. Add the liquid to the guava, lemon and pineapple juices. Make a syrup of sugar and remaining water. Cool. Combine with juices and pineapple. Chill throroughly.", "3/4 cup, 2 tsp, 2 cups, 1 1/2 tblsp, 1 1/2 cup, 1 cup, 3-4 cups", "Aloha Fruit punch", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("e7ba8f18-dca8-4d4a-936c-832bc8d8e2ea"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/xrqxuv1454513218.jpg", "Apple cider, Brown sugar, Lemonade, Orange juice, Cloves, Allspice, Nutmeg, Cinnamon", "If you use the whole all spice and cloves, tie them in cheesecloth. Heat the mixture. Stir occasionally. If you want an alcoholic drink, rum would be nice.", "4 qt, 1 cup, 6 oz frozen, 6 oz frozen, 6 whole, 6 whole, 1 tsp ground, 3 sticks", "Apple Cider Punch #1", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("864d1773-9e8b-4c3c-bb43-f4c4057f2a12"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/9a4vqb1493067692.jpg", "Tea, Rye whiskey, Red wine, Rum, Brandy, Benedictine, Orange juice, Lemon juice", "Combine all the ingredients in a large punch bowl with a block of ice. If found too dry, sugar syrup may be added. Decorate with twists of lemon peel.", "1 quart black, 1 quart, 1 fifth, 1 pint Jamaican, 1/2 pint, 1 1/2 oz, 1 pint, 1/2 pint", "Artillery Punch", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("8690f1d9-d1d0-4ba0-b8c9-d4e9755d39e8"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/n3zfrh1493067412.jpg", "Lemonade, Vodka, Blue Curacao, Triple sec, Sugar, Ice", "In a shaker, place lemonade, vodka, blue Curacao, and triple sec together. Shake with ice and strain into glass. Add sugar to taste", "5 oz, 1 oz, 1/2 oz, 1/2 oz", "Atomic Lokade", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5b90afd1-ada6-4a7a-8f41-f381d642c072"), null, "Beer", "https://www.thecocktaildb.com/images/media/drink/sxrrqq1454512852.jpg", "Lager, Cider, Blackcurrant cordial", "Pour the lager first then add the blackcurrant cordial. Top up with the cider. The colour sholud be very dark approaching the colour of Guiness.", "1/2 pint, 1/2 pint, 1 dash", "Diesel", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("96dddbef-e271-4e6f-b132-f3b74e1bc71b"), null, "Coffee / Tea", "https://www.thecocktaildb.com/images/media/drink/vyrurp1472667777.jpg", "Kahlua, Baileys irish cream, Frangelico, Coffee, Cream", "Build into a suiting glass, with no ice. Cream on top if wanted. Served directly.", "1 cl, 1 cl, 1 1/2, 4 cl hot", "Afternoon", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b4e55293-d024-472b-a863-042dc64a88bf"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/fegm621503564966.jpg", "Vodka, Amaretto, Sloe gin, Triple sec, Cranberry juice", "Pour into a large glass with ice and stir. Add a little cranberry juice to taste.", "1 shot, 1 shot, 1 shot, 1 shot", "Kool-Aid Shot", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("97619907-09b4-4820-b5f9-d160c91c5ad6"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/dlw0om1503565021.jpg", "Rum, Vodka, Gin, Blue Curacao, Sour mix, Lemon-lime soda", "Pour all ingredients into a shaker of ice. Shake well. Serve on the rocks.", "1/2 oz, 1/2 oz, 1/2 oz, 1/2 oz, 2 oz, 1 splash", "National Aquarium", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("0219ed52-49d1-45fe-84ce-b58133482aa9"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/ql7bmx1503565106.jpg", "Whiskey, Hot Damn", "Pour into shot glass. Put in mouth. Repeat as deemed necessary.", "0.75 oz, 0.25 oz", "Damned if you do", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("8d9ac919-4b5b-4da0-80cb-c6d5247b56bd"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/sxvrwv1473344825.jpg", "Vodka, Cherry liqueur, Cranberry juice, Orange juice", "Served over ice in a tall glass with a popped cherry (can add more popped cherries if in the mood)!", "2 oz, 2 oz, 4 oz, 4 oz", "Popped cherry", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("212a1368-fcfe-474c-8762-cad1040665b7"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/9179i01503565212.jpg", "Vodka, Lime, Angostura bitters, Tonic water, Ice", "Shake a tall glass with ice cubes and Angostura, coating the inside of the glass. Por the vodka onto this, add 1 slice of lime and squeeze juice out of remainder, mix with tonic, stir and voila you have a Long Vodka", "5 cl, 1/2, 4 dashes, 1 dl Schweppes, 4", "Long vodka", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("ea69f26e-8cd0-4d53-8617-82d9b3393e3f"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/0wt4uo1503565321.jpg", "Whiskey, Beer, Lemonade, Ice", "Add ingredients and mix in blender.", "12 oz, 12 oz, 12 oz frozen, 1 cup crushed", "Owen's Grandmother's Revenge", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("fa3a1010-fa28-4695-bfa0-754f11cbcdcd"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/d30z931503565384.jpg", "Amaretto, Vodka, 151 proof rum, Dr. Pepper, Beer", "Add Amaretto, Bacardi, and vodka. Mix in the Dr. Pepper and beer", "1 oz, 1 oz, 1 oz Bacardi, 1 oz, 1 oz", "Flaming Dr. Pepper", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("ab10251f-f2f0-4311-8936-b5d156cb18b5"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/b3n0ge1503565473.jpg", "Absolut Citron, Grand Marnier, Lemon juice, Club soda", "Serve in a chilled cocktail glass. Lemon and sugar the rim. Stir and Strain.", "2 oz, 1 oz, 2 oz sweetened, 1 oz", "New York Lemonade", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5dc91925-fb85-4b40-96ed-4db103584761"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/yd47111503565515.jpg", "Lime, Sugar, White rum, Ice", "Same as Caipirinha but instead of cachaca you add WHITE RUM. It's great!!!!!!!!", "2, 2 tblsp, 2-3 oz, crushed", "Caipirissima", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("05a22d02-0418-4eff-ae97-eb7e4bc21bb4"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/bylfi21504886323.jpg", "Light rum, Lemon juice, Sugar, Orange, Maraschino cherry", "In a shaker half-filled with ice cubes, combine the rum, lemon juice, and sugar. Shake well. Strain into a sour glass and garnish with the orange slice and the cherry.", "2 oz, 1 oz, 1/2 tsp superfine, 1, 1", "Rum Sour", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("34750fe7-9902-4a12-ad94-325a0d41eb84"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/tsssur1439907622.jpg", "Pisco, Lemon juice, Sugar, Ice", "Vigorously shake and strain contents in a cocktail shaker with ice cubes, then pour into glass and garnish with bitters.[1]", "2 oz, 1 oz, 1-2 tblsp", "Pisco Sour", "IBA,NewEra" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("9f04562f-6fcc-4ed2-8dd2-920084c410ce"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/wvtwpp1478963454.jpg", "Kahlua, Midori melon liqueur, Baileys irish cream", "In a shot glass add 1/3 Kahlua first. Then 1/3 Miduri, topping it off with a 1/3 bailey's irish cream", "1 part, 1 part, 1 part", "Quick F**K", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f979ee85-80e1-409f-8ca7-2ca1e5b159fa"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/tysssx1473344692.jpg", "Firewater, Absolut Peppar, Tabasco sauce", "Cover bottom of shot glass with Tabasco Sauce and then fill with half Firewater and half Absolut Peppar.", "1/2 oz, 1/2 oz, 1 dash", "Fahrenheit 5000", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("29eb79d3-d778-4f75-a1c0-ed74e8709db3"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/yrtypx1473344625.jpg", "Tequila, Tabasco sauce", "Pour Tabasco into bottom of shot glass and fill with tequila.", "1/2 oz, 1/2 oz", "Brave Bull Shooter", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("ad3fe644-2c63-44d4-ae8b-829973ac46a9"), null, "Shot", "https://www.thecocktaildb.com/images/media/drink/svsvqv1473344558.jpg", "Grenadine, Kahlua, Baileys irish cream", "In a regular-sized shot glass, layer, with a spoon or cherry, the grenadine , the Kahlua , then the Bailey's Irish cream in equal portions. It goes down really smooth ,and you don't even need a chaser. It tastes just like chocolate milk.(Really!)", "", "Bruce's Puce", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("9a21b0ec-8a76-451b-be4d-7d6b14edb191"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/xqutpr1461867477.jpg", "Everclear, Wine, Orange juice, Kool-Aid", "Add all ingredients to large bowl. Stir gently. Serve chilled.", "2 pint, 1 bottle Boone Strawberry Hill, 1/2 gal, 1 gal Tropical Berry", "Berry Deadly", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("82e945e2-8a2d-4bf0-9b0c-96dac86fc237"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/mzgaqu1504389248.jpg", "Cranberry juice, Sugar, Pineapple juice, Almond flavoring, Ginger ale", "Combine first four ingredients. Stir until sugar is dissolved, chill. Then add ginger ale just before serving. Add ice ring to keep punch cold.", "4 cups, 1 1/2 cup, 4 cups, 1 tblsp, 2 qt", "Cranberry Punch", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("cecf5da4-52d8-4098-960b-6b3225f078b2"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/wpspsy1468875747.jpg", "Egg yolk, Sugar, Milk, Light rum, Bourbon, Vanilla extract, Salt, Whipping cream, Egg white, Sugar, Nutmeg", "In a small mixer bowl beat egg yolks till blended. Gradually add 1/4 cup sugar, beating at high speed till thick and lemon colored. Stir in milk, stir in rum, bourbon, vanilla, and salt. Chill thoroughly. Whip cream. Wash beaters well. In a large mixer bowl beat egg whites till soft peaks form. Gradually add remaining 1/4 cup sugar, beating to stiff peaks. Fold yolk mixture and whipped cream into egg whites. Serve immediately. Sprinkle nutmeg over each serving. Serve in a punch bowl or another big bowl. NOTE: For a nonalcoholic eggnog, prepare Eggnog as above, except omit the bourbon and rum and increase the milk to 3 cups.", "6, 1/4 cup, 2 cups, 1/2 cup, 1/2 cup, 1 tsp, 1/4 tsp, 1 cup, 6, 1/4 cup, Ground", "Egg Nog #4", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("e38f22e3-2f80-499f-b3b9-e763654eeba4"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/quxsvt1468875505.jpg", "Egg, Sugar, Salt, Milk, Vanilla extract", "In large saucepan, beat together eggs, sugar and salt, if desired. Stir in 2 cups of the milk. Cook over low heat, stirring constantly, until mixture is thick enough to coat a metal spoon and reaches 160 degrees F. Remove from heat. Stir in remaining 2 cups milk and vanilla. Cover and regfigerate until thoroughly chilled, several hours or overnight. Just before serving, pour into bowl or pitcher. Garnish or add stir-ins, if desired. Choose 1 or several of: Chocolate curls, cinnamon sticks, extracts of flavorings, flavored brandy or liqueur, fruit juice or nectar, ground nutmeg, maraschino cherries, orange slices, peppermint sticks or candy canes, plain brandy, run or whiskey, sherbet or ice-cream, whipping cream, whipped. Serve immediately.", "6, 1/4 cup, 1/4 tsp, 1 qt, 1 tsp", "Egg-Nog - Classic Cooked", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("fb570d29-6d2b-4dd2-bfa1-4807c3a730ed"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/vuxwvt1468875418.jpg", "Red wine, Water, Sugar, Cinnamon, Cloves, Lemon peel", "Boil sugar and spices in water, leave in the water for 30 minutes. Strain the spiced water and mix with the wine. Heat slowly until short of boiling temperature. (To remove alcohol, let it boil for a while.) You may add lemon or orange juice to taste. Serve in irish coffee cup.", "1 L, 125 ml, 60 gr, 1, 3, 1 tblsp", "Gluehwein", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("3082e86c-45b9-4556-9f0c-f99466a06339"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/lfeoe41504888925.jpg", "Grape juice, Carbonated soft drink, Sherbet, Sherbet", "Take a bunch of grape juice and a bunch of fizzy stuff (club soda, ginger ale, lemonlime, whatever). Mix them in a punch bowl. Take orange sherbet and lime sherbet. Scoop out scoops and float them in the punch, let them melt a little so that a nasty film spreads all over the top of the punch but there are still \"bubbles\" in it in the form of sherbet scoops. Looks horrible, tastes just fine.", ", orange", "Holloween Punch", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4f6dca70-a0a5-40df-a8a3-b45da6a4e2c4"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/iuwi6h1504735724.jpg", "Water, Sugar, Cloves, Cinnamon, Lemon peel, Red wine, Brandy", "Simmer 3 cups water with, sugar, cloves, cinnamon sticks, and lemon peel in a stainless steel pot for 10 minutes. Add wine heat to a \"coffee temperature\" (DO NOT BOIL) then add the brandy.", "3 cups, 1 cup, 12, 2, 1, 750 ml, 1/4 cup", "Mulled Wine", "Christmas" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c9a0aead-6de4-4340-9410-40fc928faecf"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/xrvxpp1441249280.jpg", "Red wine, Sugar, Orange juice, Lemon juice, Cloves, Cinnamon", "Mix all together in a pitcher and refrigerate. Add cloves and cinnamon sticks to taste. Serve in wine glasses.", "1 bottle, 1/2 cup, 1 cup, 1 cup", "Sangria #1", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("9437e4fa-84ae-4111-8033-e61be7460cb7"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/uqqvsp1468924228.jpg", "Red wine, Sugar, Water, Apple, Orange, Lime, Lemon, Fresca", "Dissolve the sugar in hot water and cool. Peel the citrus fruits and break into wedges. Mix the wine, sugar syrup, fruit, and Fresca in a pitcher and put in the fridge for a few hours. Serve in tall glasses with a straw.", "2 bottles, 1 cup, 2 cups hot, 1 cup, wedges, wedges", "Sweet Sangria", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("441b3465-fcad-4c6f-94aa-66c9e89a468e"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/vysywu1468924264.jpg", "Red wine, Sugar, Lemon, Orange, Apple, Brandy, Soda water", "Mix wine, sugar and fruit, and let sit in the fridge for 18-24 hours. The mixture will have a somewhat syrupy consistency. Before serving stir in brandy and cut the mixture with soda water until it have a thinner, more wine like consistency. Serve from a pitcher in wine glasses.", "1 1/2 L, 1 cup, 1 large, 1 large, 1 large, 3-4 oz plain", "Sangria - The World's Best", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("1f19e92c-4f02-49ee-a13b-e8b29fd178de"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/qxvypq1468924331.jpg", "Peach nectar, Orange juice, Brown sugar, Cinnamon, Cloves, Lime juice", "Combine peach nectar, orange juice and brown sugar in a large saucepan. Tie cinnamon and cloves in a small cheesecloth bag. Drop into saucepan. Heat slowly, stirring constantly, until sugar dissolves. Simmer 10 minutes. Stir in lime juice. Serve in hot mugs.", "46 oz, 20 oz, 1/2 cup, 3 3-inch, 1/2 tsp, 2 tblsp", "Spiced Peach Punch", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5675ca73-d4aa-45d4-9c85-4daae9bec3d7"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/spvvxp1468924425.jpg", "Lemon, Sugar, Strawberries, Water", "Throw everything into a blender and mix until fairly smooth. Serve over ice.", "Juice of 1, 1 tblsp, 8-10 ripe, 1 cup", "Strawberry Lemonade", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4bb9831b-0179-4be4-bfd7-d73c6eb51307"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/rywtwy1468924758.jpg", "Pineapple juice, Club soda, Orange juice, Lemon, Berries, Champagne", "Combine all ingredients in a punch bowl.", "46 oz chilled, 28 oz, 6 oz frozen, 1, 2 cups, 1 bottle", "Sunny Holiday Punch", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("1519ab2a-b231-4dc2-a55d-297e32732699"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/yutxtv1473344210.jpg", "Red wine, Lemon-lime soda, Ice", "Mix wine and soft drink. Pour into glass. Add ice.", "2 oz white or, 5 oz, cubes", "Wine Cooler", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a47919b8-5a8f-4f98-982a-8650abe5cea4"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/txustu1473344310.jpg", "Red wine, Lemon, Orange juice, Orange, Pineapple juice", "Combine all of the ingredients and pour over a block of ice.", "1 bottle, 2, 1 cup, 3, 1 cup", "Wine Punch", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("6e9e4df4-1cff-45cc-895c-b08e7e904239"), null, "Cocoa", "https://www.thecocktaildb.com/images/media/drink/u6jrdf1487603173.jpg", "Heavy cream, Milk, Cinnamon, Vanilla, Chocolate, Whipped cream", "Heat the cream and milk with the cinnamon and vanilla bean very slowly for 15-20 minutes. (If you don't have any beans add 1-2 tsp of vanilla after heating). Remove the bean and cinnamon. Add the chocolate. Mix until fully melted. Serve topped with some very dense fresh whipped cream. Serves 1-2 depending upon how much of a glutton you are. For a richer chocolate, use 4 oz of milk, 4 oz of cream, 4 oz of chocolate. Serve in coffee mug.", "2 oz, 6-8 oz, 1 stick, 1, 2 oz finely chopped dark, Fresh", "Drinking Chocolate", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("98348e09-4c60-44c4-ae4c-6100cd273090"), null, "Cocoa", "https://www.thecocktaildb.com/images/media/drink/q7w4xu1487603180.jpg", "Chocolate, Milk, Water", "Melt the bar in a small amount of boiling water. Add milk. Cook over low heat, whipping gently (with a whisk, i would assume) until heated well. Don't let it boil! Serve in coffee mug.", "125 gr, 3/4 L", "Chocolate Drink", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("ea0fe1eb-c1b2-4c90-b68d-bb39ee8f200f"), null, "Punch / Party Drink", "https://www.thecocktaildb.com/images/media/drink/qxuppv1468875308.jpg", "Egg, Sugar, Condensed milk, Milk, Vanilla extract, Rum, Nutmeg", "Whip egg substitute and sugar together, combine with the two kinds of milk, vanilla, and rum. Mix well. Chill over night. Sprinkle with nutmeg. Makes 6 servings.", "1/2 cup, 3 tblsp, 13 oz skimmed, 3/4 cup skimmed, 1 tsp, 1 tsp, , , , , , ", "Egg Nog - Healthy", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("47ccd38e-777a-41e7-be5d-f8948820db36"), null, "Cocoa", "https://www.thecocktaildb.com/images/media/drink/3nbu4a1487603196.jpg", "Cocoa powder, Sugar, Cornstarch, Water, Milk", "Shift the cocoa and sugar together into a medium-sized saucepan. Dissolve the cornstarch in the water, and stir into the cocoa and sugar until it is a smooth paste. Begin heating the mixture, stirring it with a whisk, and gradually pour in the milk. Continue stirring with the whisk as you bring the liquid to a simmer. Allow the chocolate to simmer for about 10 minutes, stirring often, until it is thick, glossy and completely smooth. Serve steaming hot in coffee mug. Serves six.", "1/2 cup, 1 cup, 7 tsp, 1/2 cup, 1 qt", "Castillian Hot Chocolate", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f8c7dec7-abd7-4a4e-a4df-3ed55daacc0c"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/2bcase1504889637.jpg", "Tequila, Lemon juice, Grenadine, Egg white, Ginger ale", "Shake all ingredients (except ginger ale) with ice and strain into a collins glass over ice cubes. Fill with ginger ale, stir, and serve.", "2 oz, 1 tblsp, 3/4 oz, 1", "Tequila Fizz", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f0c70e8c-492a-4d61-a030-32e1b17123be"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/ek0mlq1504820601.jpg", "Tequila, Lemon, Powdered sugar, Lemon, Cherry", "Shake tequila, juice of lemon, and powdered sugar with ice and strain into a whiskey sour glass. Add the half-slice of lemon, top with the cherry, and serve.", "2 oz, Juice of 1/2, 1 tsp, 1/2 slice, 1", "Tequila Sour", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("baad025b-327d-4dc2-b7be-50801eedea43"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/rvuswq1461867714.jpg", "Scotch, Wine, Orange juice", "In a shaker half-filled with ice cubes, combine all of the ingredients. Shake well. Strain into a cocktail glass.", "1 1/2 oz, 1 oz Green Ginger, 1 oz", "Thriller", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("28ff7504-ecc0-47c6-920b-536d2e309a5e"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/qystvv1439907682.jpg", "Gin, Lemon juice, Sugar, Club soda, Maraschino cherry, Orange", "In a shaker half-filled with ice cubes, combine the gin, lemon juice, and sugar. Shake well. Strain into a collins glass alomst filled with ice cubes. Add the club soda. Stir and garnish with the cherry and the orange slice.", "2 oz, 1 oz, 1 tsp superfine, 3 oz, 1, 1", "Tom Collins", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5d719b05-1f76-46c1-89c8-ad94ef45a9cc"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/utypqq1441554367.jpg", "Dry Vermouth, Gin, Anis, Bitters, Orange peel", "Stir all ingredients (except orange peel) with ice and strain into a cocktail glass. Add the twist of orange peel and serve.", "1 oz, 1 oz, 1/4 tsp, 2 dashes, Twist of", "Turf Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("338279dd-078d-4394-8b20-efc52b39525c"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/4u0nbl1504352551.jpg", "Dry Vermouth, Gin, Maraschino liqueur, Anis, Orange bitters, Cherry", "Stir all ingredients with ice and strain into a cocktail glass. Garnish with a cherry and a twist of lemon zest.", "1 1/2 oz, 1 1/2 oz, 1/4 tsp, 1/4 tsp, 2 dashes, 1", "Tuxedo Cocktail", "IBA,Classic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("094f2ec4-b671-4610-8d5b-51f129dfddde"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/tqyrpw1439905311.jpg", "Strawberry schnapps, Tequila, Triple sec, Lemon juice, Strawberries, Salt", "Rub rim of cocktail glass with lemon juice and dip rim in salt. Shake schnapps, tequila, triple sec, lemon juice, and strawberries with ice, strain into the salt-rimmed glass, and serve.", "1/2 oz, 1 oz, 1/2 oz, 1 oz, 1 oz", "Strawberry Margarita", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("f03ee05e-30d3-4fad-a400-e1a1e25d4b5d"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/9myuc11492975640.jpg", "Apricot brandy, Orange juice, Orange bitters", "Shake all ingredients with ice, strain into a cocktail glass, and serve.", "1 1/2 oz, 1 tblsp, 2 dashes", "Valencia Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("e9f3f5a2-05f1-4694-8769-01841ab4ebbf"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/tswpxx1441554674.jpg", "Dry Vermouth, Creme de Cassis, Carbonated water", "Stir vermouth and creme de cassis in a highball glass with ice cubes. Fill with carbonated water, stir again, and serve.", "1 1/2 oz, 3/4 oz", "Vermouth Cassis", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7be5f52f-1449-4fa7-a9d5-c942d7c0316b"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/26cq601492976203.jpg", "Light rum, Sweet Vermouth, Lemon, Powdered sugar, Egg white", "Shake all ingredients with ice, strain into an old-fashioned glass over ice cubes, and serve.", "1 oz, 1/2 oz, Juice of 1/2, 1 tsp, 1", "Vesuvio", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("951d43f0-7a2e-466f-9110-e40e69999d12"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/iwml9t1492976255.jpg", "Dark rum, Cherry brandy", "Pour the rum and cherry brandy into an old-fashioned glass almost filled with ice cubes. Stir well.", "2 oz, 1/2 oz", "Veteran", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("49a1d689-8101-4314-9503-34e096f0dc10"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/voapgc1492976416.jpg", "Gin, Sweet Vermouth, Brandy", "Shake all ingredients with ice, strain into a cocktail glass, and serve.", "1 1/2 oz, 1/2 oz, 1/2 oz", "Victor", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("89cfa981-fd22-4905-8cbe-b9a331262470"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/lx0lvs1492976619.jpg", "Vodka, Lemon juice, Grape juice, Powdered sugar, Orange", "Shake all ingredients (except orange slice) with ice and strain into a collins glass over ice cubes. Add the slice of orange and serve.", "1 1/2 oz, 3 oz, 3 oz unsweetened, 1 tsp, 1 slice", "Victory Collins", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("2a637911-0e60-453a-b061-435eccf4b09f"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/lmj2yt1504820500.jpg", "Vodka, Tonic water", "Pour vodka into a highball glass over ice cubes. Fill with tonic water, stir, and serve.", "2 oz", "Vodka And Tonic", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("3ec7f643-84e7-4a49-9abf-9f2c8ae302f1"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/fgq2bl1492975771.jpg", "Light rum, Maple syrup, Lemon juice", "Shake all ingredients with ice, strain into an old-fashioned glass over ice cubes, and serve.", "3 oz, 1 oz, 1 oz", "Van Vleet", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("3cf38efb-6cbe-47d0-b0d4-8c08acc20a2e"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/ysuqus1441208583.jpg", "Triple sec, Gin, Pineapple juice", "Shake all ingredients with ice, strain into a cocktail glass, and serve.", "3/4 oz, 3/4 oz, 1 tblsp", "Waikiki Beachcomber", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("47d1b0b8-cddf-4332-9df2-9d4654515ade"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/deu59m1504736135.jpg", "Strawberry schnapps, Light rum, Lime juice, Powdered sugar, Strawberries", "Pour all ingredients into shaker with ice cubes. Shake well. Strain in chilled cocktail glass.", "1/2 oz, 1 oz, 1 oz, 1 tsp, 1 oz", "Strawberry Daiquiri", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b5335be0-4490-4c0d-8f6f-80d0cb6ff91c"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/d7mo481504889531.jpg", "Sloe gin, Dry Vermouth, Orange bitters", "Stir all ingredients with ice, strain into a cocktail glass, and serve.", "2 oz, 1/4 tsp, 1 dash", "Sloe Gin Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5ae7205e-a619-475a-88d0-73e6c3074368"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/yqsvtw1478252982.jpg", "Scotch, Drambuie, Lemon peel", "Pour the Scotch and Drambuie into an old-fashioned glass almost filled with ice cubes. Stir well. Garnish with the lemon twist.", "1 1/2 oz, 1/2 oz, 1 twist of", "Rusty Nail", "IBA,Classic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("da08aa6d-37d9-4fad-a1c8-50e20c115b43"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/4vfge01504890216.jpg", "Grapefruit juice, Gin, Salt", "Pour all ingredients over ice cubes in a highball glass. Stir well and serve. (Vodka may be substituted for gin, if preferred.)", "5 oz, 1 1/2 oz, 1/4 tsp", "Salty Dog", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a8bdd2ea-a489-4201-8781-51e6032b553f"), null, "Cocoa", "https://www.thecocktaildb.com/images/media/drink/jbqrhv1487603186.jpg", "Milk, Chocolate, Cinnamon, Egg", "Boil milk in the top of a deep double boiler five minutes. Remove from fire and add chocolate, mixed with the cinnamon, a little at a time, beating with molinillo or egg beater after each addition. When the chocolate is thoroughly blended, heat to the boiling point. Place over bottom of double boiler and add eggs, whipping constantly, until they are thoroughly blended and the mixture is frothing. Serve in coffee mug. Serves eight.", "6 cups, 3 oz Mexican, 1 tsp powdered, 3", "Chocolate Beverage", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("aead116e-fd97-4c4f-b15c-1dad2f586b0f"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vvpxwy1439907208.jpg", "Ricard, Sugar, Peychaud bitters, Water, Bourbon, Lemon peel", "Rinse a chilled old-fashioned glass with the absinthe, add crushed ice, and set it aside. Stir the remaining ingredients over ice and set it aside. Discard the ice and any excess absinthe from the prepared glass, and strain the drink into the glass. Add the lemon peel for garnish.", "1 tsp, 1/2 tsp superfine, 2 dashes, 1 tsp, 2 oz, 1 twist of", "Sazerac", "IBA,Classic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("505d8614-9c31-41f6-8349-3ff2081d9eef"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/twuptu1483388307.jpg", "Brandy, Amaretto, Light cream", "Shake all ingredients well with cracked ice, strain into a cocktail glass, and serve.", "1 oz, 1 oz, 1 oz", "Scooter", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("18049a89-5c93-4331-a83d-21e94d1f4e84"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/1q7coh1504736227.jpg", "Scotch, Brandy, Curacao, Orange, Mint", "Pour scotch, brandy, and curacao over ice in an old-fashioned glass. Add the orange slice, top with the mint sprig, and serve.", "2 oz, 4 dashes, 4 dashes, 1 slice, 1", "Scotch Cobbler", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b287972e-4913-4faf-981e-43de945d71b4"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/3gz2vw1503425983.jpg", "Brandy, Anisette", "Shake ingredients with ice, strain into a brandy snifter, and serve. (The English translation of the name of this drink is \"Sun and Shade\", and after sampling this drink, you'll understand why. Thanks, Kirby.)", "1 1/2 oz, 1 1/2 oz", "Sol Y Sombra", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("71479fe8-b76a-4155-b4d2-1d3cf3a4b50d"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/0dnb6k1504890436.jpg", "Scotch, Lime, Powdered sugar, Lemon, Cherry", "Shake scotch, juice of lime, and powdered sugar with ice and strain into a whiskey sour glass. Decorate with 1/2 slice lemon, top with the cherry, and serve.", "1 1/2 oz, Juice of 1/2, 1/2 tsp, 1/2 slice, 1", "Scotch Sour", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("2774b1bc-e357-4562-9c09-aaca5a9c717a"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/ttyrxr1478820678.jpg", "Light rum, Anisette, Grenadine, Lemon", "Shake all ingredients with ice, strain into a cocktail glass, and serve.", "1 oz Jamaican, 1 tsp, 1/2 tsp, Juice of 1/4", "Shanghai Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("efa18689-e790-4826-9328-797751e00b32"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/xwrpsv1478820541.jpg", "Sherry, Powdered sugar, Egg, Milk, Nutmeg", "Shake sherry, powdered sugar, and egg with ice and strain into a collins glass. Fill with milk and stir. Sprinkle nutmeg on top and serve.", "2 oz cream, 1 tsp, 1 whole", "Sherry Eggnog", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("0223e33c-ec54-4c56-a7c3-716ca5b27510"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/qrryvq1478820428.jpg", "Sherry, Light cream, Powdered sugar, Egg, Nutmeg", "Shake all ingredients (except nutmeg) with ice and strain into a whiskey sour glass. Sprinkle nutmeg on top and serve.", "1 1/2 oz cream, 2 tsp, 1 tsp, 1 whole", "Sherry Flip", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7ed916a7-a806-49ce-bf3b-917a11544c52"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/stwxuq1439906852.jpg", "Cognac, Cointreau, Lemon juice", "Pour all ingredients into cocktail shaker filled with ice. Shake well and strain into cocktail glass.", "2 oz, 1/2 oz, 1 oz", "Sidecar", "IBA,Classic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("713e8e50-b266-425d-b78b-b508d42289d6"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/ewjxui1504820428.jpg", "Brandy, Triple sec, Lemon", "Shake all ingredients with ice, strain into a cocktail glass, and serve.", "1 oz, 1/2 oz, Juice of 1/4", "Sidecar Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("9540855f-e64f-433c-bfd9-4075318f239c"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/tvtrrt1439906288.jpg", "Cherry brandy, Grenadine, Gin, Sweet and sour, Carbonated water, Cherry", "Pour all ingredients into cocktail shaker filled with ice cubes. Shake well. Strain into highball glass. Garnish with pineapple and cocktail cherry.", "1/2 oz, 1/2 oz, 1 oz, 2 oz", "Singapore Sling", "IBA,ContemporaryClassic" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("77f964e4-6d6a-4947-9193-3efd5cd53b72"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/8xnyke1504352207.jpg", "Vodka, Orange juice", "Mix in a highball glass with ice. Garnish and serve.", "2 oz", "Screwdriver", "IBA" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("b4cd2b3e-5f34-4215-a0aa-755caefde73d"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/yvvwys1461867858.jpg", "Scotch, Wine", "Pour both of the ingredients into a wine goblet with no ice.", "1 1/2 oz, 1 oz Green Ginger", "Whisky Mac", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("83fe450a-180d-4b72-a21b-5c4e12f53cda"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vruvtp1472719895.jpg", "Apricot brandy, Orange juice, Sweet and sour", "Shake all ingredients with ice, strain into a chilled whiskey sour glass, and serve.", "1 oz, 1 oz, 1 oz", "Stone Sour", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("cf8a74b4-1349-419f-9fb0-3edfd043982e"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/vuquyv1468876052.jpg", "Grenadine, Orange juice, Pineapple juice", "Mix. Serve over ice.", "1 part, 4 parts, 4 parts", "Afterglow", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("5dfef187-10f0-43b7-8b14-ba742826b856"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/1bw6sd1487603816.jpg", "Mango, Yoghurt, Sugar, Water", "Put it all in a blender and pour over crushed ice. You can also use other fruits like strawberries and bananas.", "2, 2 cups, 1/2 cup, 1 cup iced", "Lassi - Mango", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("2a348a25-d6ec-4d84-b8ba-2887412617ea"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/eirmo71487603745.jpg", "Ginger, Water, Lemon, Sugar, Cayenne pepper", "Juice the lemons. Peel and grate the ginger. Place the grated ginger and a liberal dash of the cayenne pepper into a piece of cheesecloth, and tie it into a knot. Let soak in the water. After 15 minutes or so, add the sugar, and the lemon juice. Chill, and serve.", "2 pieces, 1 gal, 1 lb, 1 cup, ground", "Lemouroudji", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("3e2a1462-74df-4e46-9242-e2ff6d7df78c"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/5jdp5r1487603680.jpg", "Lime, Sugar, Soda water, Lime peel", "In a large glass, put the lime juice and sugar, and stir well. Add cold seltzer water to fill. Put the lime peels in the glass. Drink. Repeat until limes or soda run out.", "Juice of 1, 1 tblsp, (seltzer water)", "Limeade", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a7d5e15a-9f70-4ed9-bd60-bedf71a2e0c0"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/bcsj2e1487603625.jpg", "Lime juice, Gin, Aperol", "Shake with ice and strain into cocktail glass.", "4 cl, 2 cl, 4 cl", "Imperial Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("52d76d8c-7f4b-4373-8f48-61ca924fcac8"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/xwqvur1468876473.jpg", "Berries, Apple", "Throw everything into a blender and liquify.", "1 cup, 2", "Apple Berry Smoothie", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("2a647ddf-a4ea-451e-9ea2-00aa7bf3e414"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/54z5h71487603583.jpg", "Grapes, Lemon, Pineapple", "Throw everything into a blender and liquify.", "1 cup, 1/4, 1/2", "Grape lemon pineapple Smoothie", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d14f9352-dee9-4eb3-972f-d2329414eafc"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/jogv4w1487603571.jpg", "Kiwi, Papaya", "Throw everything into a blender and liquify.", "3, 1/2", "Kiwi Papaya Smoothie", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("8e34e802-d959-44d0-8dd5-54f42cb01044"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/vdp2do1487603520.jpg", "Mango, Orange", "Throw everything into a blender and liquify.", "1, 2", "Mango Orange Smoothie", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("a7a890bc-12eb-494f-9f4b-85ed337eba5a"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/eg9i1d1487603469.jpg", "Ginger, Pineapple", "Throw everything into a blender and liquify.", "1/4 inch, 1/2", "Pineapple Gingerale Smoothie", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7e4af52c-01bb-4db3-848a-33959059a79c"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/7j1z2e1487603414.jpg", "Ginger, Lemon, Water", "Juice ginger and lemon and add it to hot water. You may add cardomom.", "1 inch, 1/4, 1 cup hot", "Kill the cold Smoothie", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("64d656b1-e372-48ae-b38e-82ec8affe2ba"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/9h1vvt1487603404.jpg", "Strawberries, Honey, Water", "Place all ingredients in the blender jar - cover and whiz on medium speed until well blended. Pour in one tall, 2 medium or 3 small glasses and drink up.", "1 1/2 cup, 4 tsp, 1/2 cup", "Strawberry Shivers", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("752201ac-0891-4cc1-aa72-0449d14f37d8"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/trttrv1441254466.jpg", "Yoghurt, Fruit, Ice", "Place all ingredients in the blender jar - cover and whiz on medium speed until well blended. Pour in one tall, 2 medium or 3 small glasses and drink up. Note: Use lots of ice in this one - great on hot days! To add ice: Remove the center of the cover while the blender is on - drop 3 or 4 ice cubs and blend until they're completely crushed.", "1 cup, 1 cup", "Yoghurt Cooler", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("64878e20-4fa5-4108-8761-2f6a485d81e7"), null, "Ordinary Drink", "https://www.thecocktaildb.com/images/media/drink/vsrupw1472405732.jpg", "Vodka, Coffee liqueur, Light cream", "Pour vodka and coffee liqueur over ice cubes in an old-fashioned glass. Fill with light cream and serve.", "2 oz, 1 oz", "White Russian", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("e4815e73-9fd9-4cd9-8924-d5050c84c3e0"), null, "Milk / Float / Shake", "https://www.thecocktaildb.com/images/media/drink/sxpcj71487603345.jpg", "Milk, Banana, Honey", "Place all ingredients in the blender jar - cover and whiz on medium speed until well blended. Pour in one tall, 2 medium or 3 small glasses and drink up.", "2 cups, 1, 1 tblsp", "Sweet Bananas", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("73b7d799-a351-4562-a12a-0ad9b2e60464"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/869qr81487603278.jpg", "Tomato juice, Lemon juice, Celery salt", "Place all ingredients in the blender jar - cover and whiz on medium speed until well blended. Pour in one tall, 2 medium or 3 small glasses and drink up.", "2 cups, 1-2 tblsp, 1 dash", "Tomato Tang", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("fa47f66e-7c19-4ffe-9c4d-585e3a41003b"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/9jeifz1487603885.jpg", "Yoghurt, Water, Sugar, Salt, Lemon juice", "Put all ingredients into a blender and blend until nice and frothy. Serve chilled.", "1 cup, 2 cups cold, 4 tblsp, pinch, 2 tblsp", "Lassi - Sweet", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("938edda4-f9dd-412d-a6bc-237961abd6a3"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/s4x0qj1487603933.jpg", "Yoghurt, Ice, Sugar, Lime, Salt", "Blend the yoghurt and ice cubes together, until the yoghurt becomes more liquid. Add sugar to taste. The lemon/lime is optional but it gives it a slightly tart taste. Dash of salt. Raita is also good for the summer. Instead of having a traditional salad you can make raita instead.", "2 cups, 4-6", "Lassi Raita", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d47dc996-1c15-47fe-8c6d-f4b0342bef71"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/uqxqsy1468876703.jpg", "Cantaloupe, Banana", "Juice cantaloupe, pour juice into blender, add banana, and liquify.", "Juice of 1/2, 1", "Banana Cantaloupe Smoothie", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("7e8457f5-d7c6-474b-a579-b5c571a7a93c"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/iq6scx1487603980.jpg", "Yoghurt, Water, Cumin seed, Salt, Mint", "Blend in a blender for 3 seconds. Lassi is one of the easiest things to make, and there are many ways of making it. Basically, it is buttermilk (yoghurt whisked with water), and you can choose almost any consistency that you like, from the thinnest to the thickest. Serve cold.", "1/2 cup plain, 1 1/4 cup cold, 1/2 tsp ground roasted, 1/4 tsp, 1/4 tsp dried", "Lassi - A South Indian Drink", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("6e87f5e3-87fd-4a47-9e36-062325525733"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/xwuqvw1473201811.jpg", "Pineapple juice, Passion fruit juice, Lemon juice, Grenadine", "Prepare in a blender or shaker, serve in a highball glass on the rocks. Garnish with 1 slice of pineapple and one cherry.", "10 cl, 6 cl, 1 cl, 1 cl", "Bora Bora", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("8a071136-b7af-4cfe-8776-455a06a085de"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/m1suzm1487603970.jpg", "Yoghurt, Water, Salt, Asafoetida", "Blend (frappe) in blender until frothy. Add torn curry leaves and serve cold.", "1 cup, 2 cups cold, 1 tsp, 1 pinch", "Lassi Khara", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("4d1fe629-3312-4ea8-84a9-426431f34dee"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/ytsxxw1441167732.jpg", "Lemon juice, Orange juice, Sugar syrup, Soda water", "Place some ice cubes in a large tumbler or highball glass, add lemon juice, orange juice, sugar syrup, and stir well. Top up with cold soda water, serve with a drinking straw.", "5 cl, 15 cl, 2-3 cl", "Orangeade", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("12d1c3a6-1c15-4b11-88b6-1c9f3c904a39"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/stsuqq1441207660.jpg", "Sugar syrup, Lemon juice, Ginger ale", "Mix sugar syrup with lemon juice in a tall glass. Fill up with ginger ale.", "2 tsp", "Rail Splitter", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("59b85ac3-65b4-4771-8b26-cb815117a827"), null, "Milk / Float / Shake", "https://www.thecocktaildb.com/images/media/drink/vqquwx1472720634.jpg", "Strawberries, Banana, Yoghurt, Milk, Honey", "Blend all together in a blender until smooth.", "1/2 lb frozen, 1 frozen, 1 cup plain, 1 cup, to taste", "Banana Strawberry Shake", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("03c5c71e-bcff-43a3-b3e8-5a9484d51e2f"), null, "Milk / Float / Shake", "https://www.thecocktaildb.com/images/media/drink/uvypss1472720581.jpg", "Strawberries, Banana, Apple juice", "Blend all together in a blender until smooth.", "1/2 lb frozen, 1 frozen, 2 cups fresh", "Banana Strawberry Shake Daiquiri-type", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("0c72e4db-eed1-47f7-8c07-7fc1837f48f0"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/mvis731484430445.jpg", "Chocolate syrup, Milk, Soda water", "Mix syrup and milk in a fountain glass. Add soda water, serve with a straw.", "2 tblsp, 6 oz whole, 6 oz", "Egg Cream", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("44337e7e-d876-4d32-9c45-e181d88beac2"), null, "Milk / Float / Shake", "https://www.thecocktaildb.com/images/media/drink/rtwwsx1472720307.jpg", "Milk, Orange juice, Sugar syrup, Banana", "Blend very well, preferably in a household mixer. Serve in a wine glass, garnish with whipped cream and a piece of banana.", "10 cl cold, 4 cl, 2 tsp, 1/2", "Banana Milk Shake", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("1ae2814c-5aa6-43dc-92d8-aab1f6c052e1"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/i3tfn31484430499.jpg", "Apple juice, Strawberries, Sugar, Lemon, Apple, Soda water, Ice", "Toss strawberries with sugar, and let sit overnight in refrigerator. Cut lemon, reserve two slices. Juice the rest. Mix together the lemon juice, strawberries, apple juice, and soda water. Add slices of lemon (decor, really). In glasses, put ice cubes, and a slice of apple. Pour drink in, and serve.", "1 can frozen, 1 cup, 2 tblsp, 1, 1, 1 L", "Fruit Cooler", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("83adae8b-737e-4ef1-ae7a-fe26ace6b096"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/nfdx6p1484430633.jpg", "Yoghurt, Fruit juice", "Place all ingredients in the blender jar - cover and whiz on medium speed until well blended. Pour in one tall, 2 medium or 3 small glasses and drink up.", "1 cup, 1 cup", "Fruit Flip-Flop", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("0f0624ff-d426-495b-bbcf-15b325e2c9db"), null, "Other/Unknown", "https://www.thecocktaildb.com/images/media/drink/q0fg2m1484430704.jpg", "Yoghurt, Banana, Orange juice, Fruit, Ice", "Blend til smooth.", "1 cup fruit, 1, 4 oz frozen, 1/2 piece textural, 6", "Fruit Shake", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("c4f9f591-2b12-4373-a1c5-d1d370e7d7b5"), null, "Milk / Float / Shake", "https://www.thecocktaildb.com/images/media/drink/znald61487604035.jpg", "Milk, Chocolate syrup, Mint syrup", "Place all ingredients in the blender jar - cover and whiz on medium speed until well blended. Pour in one tall, 2 medium or 3 small glasses and drink up.", "2 cups", "Just a Moonmint", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("168cfce7-6218-4eee-9244-947f870c382b"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/qyqtpv1468876144.jpg", "Grenadine, Orange juice, Pineapple juice, Cream", "Shake well, strain into a large cocktail glass.", "1 cl, 1 cl, 2 cl, 4 cl", "Alice Cocktail", null });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "ID", "AlternateName", "Category", "Image", "Ingredients", "Instructions", "Measures", "Name", "Tags" },
                values: new object[] { new Guid("d0ba3af5-52b7-40cf-998d-53ae10040972"), null, "Cocktail", "https://www.thecocktaildb.com/images/media/drink/syusvw1468876634.jpg", "Apple juice, Carrot", "Place all ingredients in the blender jar - cover and whiz on medium speed until well blended. Pour in one tall, 2 medium or 3 small glasses and drink up.", "2 cups, 1 large", "Apple Karate", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6e110a47-0371-466b-b3cb-dbd010879906"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8202), "Pisang Ambon", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0ce07aa9-4c7f-4a0e-aab8-15794243d0d9"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8311), "Malibu rum", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7af50dc9-820d-43cf-a28f-5f4505ddb990"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8287), "Creme de Banane", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("57d92330-62f7-4907-8c44-71052b337ea8"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8348), "Vanilla vodka", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8370a145-9361-42cc-b03d-5cf9101b0b33"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8270), "Hot chocolate", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6cb27ffd-de65-4572-a2cd-806c75feb61e"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8242), "Cherry Heering", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("10cd45c3-e8d1-478d-9396-b8dcca85549a"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8215), "Bitter lemon", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("89db3f69-a391-4c4a-a944-737511aa1802"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8327), "Dark Creme de Cacao", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("17a5cc78-c7f5-4ba3-ad48-2d5276ae6d81"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8062), "Crown Royal", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9bc36e93-8d63-4035-855c-9344cc753037"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8156), "Godiva liqueur", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b5b9dddc-35b7-4962-b041-1d2f9db60d94"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8123), "Chambord raspberry liqueur", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bf6d04d0-1721-43cc-bc89-c10f53a37cdb"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8092), "Vermouth", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("172a7594-7925-4e51-9fb8-896fe99928de"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8046), "Coconut liqueur", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("555f5c91-edec-4bf2-931c-5b14f741d72c"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7932), "Pina colada mix", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b78445bf-b3c4-44e1-9ce5-6e7b7adb580f"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7979), "Daiquiri mix", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9e61e56e-1b44-479c-99aa-b821f0b9e43f"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8405), "Wild Turkey", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e18bfd36-2c2a-448c-bf63-ae26ae4731cd"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8027), "Butterscotch schnapps", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e7fd60c9-aa25-4bcf-ac08-3317866dcedd"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7996), "Absolut Vodka", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("49e7131e-8357-4615-8dba-21fa01dec82c"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8173), "Absolut Kurant", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("102003b9-b18c-4c81-bbd4-cd45215df97e"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8424), "Grape soda", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("36ad1151-72be-4f98-8e5c-f59b6cb3bbdf"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8902), "Coconut rum", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6a0bb3c3-380c-4bf3-b7c8-e614d61851b4"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8463), "Banana liqueur", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7550543f-2f88-43eb-a75c-8f3ac4a61221"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9065), "Kirschwasser", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1c14cd94-4f77-414b-b43b-f6ccbeea92e6"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9044), "Chocolate milk", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bea49f74-347e-4029-85a4-e72b004fa431"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7915), "Jim Beam", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5113e527-3fd4-4a38-82ca-a71cd691998a"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9117), "Strawberry liqueur", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("134ccfac-69cc-411d-b45a-b9724c369967"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9019), "Aquavit", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ba9ff7a9-e3e4-4e23-a348-12b9454fa07f"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8952), "Root beer", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7e3da694-e891-48a1-8c70-2d2d85bb5660"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8938), "Cherries", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a2f054c3-b4bb-4839-8e6b-78414c4e2815"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8919), "Tropicana", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1fcc43cc-d52c-4e3a-a338-db3d5beec437"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8875), "Yukon Jack", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0d121e19-d13c-4698-b0e5-e6bad2c7ca3f"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8720), "Bacardi Limon", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("446f36d0-cd23-4f18-a3bf-4442e9a5e2b2"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8708), "Corona", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("67cdab77-2439-4964-b779-bb309078ab67"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8648), "Schweppes Russchian", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("df96f62d-fab7-45b0-b95e-70f0684ca3c8"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8635), "Apfelkorn", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("42d03d7d-e3a7-43a3-a995-5fd6a5f96414"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8575), "Cranberry vodka", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8e946742-ce33-4c4b-8900-6120614d1e00"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8551), "Fruit punch", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0870f964-b9d8-46d9-b3ff-08e810be7da8"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8535), "Jello", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0d155489-763b-4c88-9a6c-bc8900bd16b6"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8520), "Surge", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0b13a8d1-cddf-423b-979a-44bfbcb676e0"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8504), "Peachtree schnapps", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("432c2195-0738-420e-8531-239e74203a5f"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8478), "Kiwi liqueur", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e14e3392-100b-4464-b559-590fc75982a0"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(8439), "Candy", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e3d5d892-4dbc-4fc8-b9d7-b094206bdc41"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7896), "Jack Daniels", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1b6ee669-6c8f-4f39-9608-1acae8e40f17"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7298), "Firewater", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c7a5c064-211b-4e3f-adec-03607c4ff84e"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7845), "Apple schnapps", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("38162294-d341-48e3-9121-496f9570aa78"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7413), "Sour mix", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c4ff0ee4-80d1-454e-9b02-a628d23788d8"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7391), "Frangelico", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("369d1d20-3604-4611-9a5d-3da82d184eb3"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7374), "Blackcurrant cordial", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("760cbbf8-37f7-479d-ab51-e0f7ba454fad"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7362), "Cider", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5fea7648-4588-4e66-be03-e6e5f08da1ea"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7349), "Lager", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0371cb58-3c29-4b9c-ade2-81437fed21e9"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7326), "Cherry liqueur", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e8e5081e-e224-48a2-9863-3b9deeee17e2"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7311), "Absolut Peppar", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fd4e29d1-95ba-4284-bf90-947e932dd892"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7251), "Peach nectar", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("69f92a7f-6710-4569-8bff-80600197ea64"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7428), "Whiskey", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("50c0cdc7-93e9-4515-889d-f00cf1263f5b"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7167), "Fresca", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ff961c77-419a-424e-a994-2b0760d2c5de"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7124), "Carbonated soft drink", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b7c5d83b-3a28-42bb-b1cb-577a652a1543"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7075), "Kool-Aid", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("43ca2a30-0c24-43c7-88b4-dd66a1a17e84"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7058), "Everclear", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d4420e1d-5aff-4fd0-935b-f6bbf36473af"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7039), "Rye whiskey", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8d7b798a-a398-4f80-893f-537269ae56ca"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7016), "Apple cider", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2a51ca95-539e-4444-b266-a20082ed1a25"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9143), "Black Sambuca", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e1a42003-2956-4dc9-b891-38208526eef4"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6981), "Brown sugar", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6f7ab0fa-3c74-4e12-a183-5261fc2bf38e"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7000), "Guava juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b025aecc-694a-4ee5-890a-ac6ca34b2c1f"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7137), "Sherbet", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cacee263-767a-4e0d-8423-7e336d27cf1c"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7440), "Hot Damn", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f698cb8d-0e92-4e67-99df-c23fa76a4f21"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7461), "Midori melon liqueur", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d771e8ec-3a78-42af-8f53-4f19ebed0585"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7479), "Beer", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("35a78344-c918-42cc-a19b-14eceb0cd632"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7833), "7-Up", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("55e9344a-799d-4e5c-aa79-cbeeb14bb5bd"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7819), "Sarsaparilla", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9dd89f74-b8f5-492e-ac09-b2a6c29471e9"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7795), "Iced tea", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a964d7cf-4649-46df-921f-e8e2b4c03aad"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7780), "Pink lemonade", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("023c7599-a265-4db9-bba9-dc43713c0dea"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7765), "Sprite", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6c1b3d19-4541-4add-baa4-c1903b93a055"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7746), "Oreo cookie", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("82e336c5-d727-47ee-9824-a210b4c7c42d"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7734), "Vanilla ice-cream", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("77fe2c7b-a715-4535-87e4-49ee4d2b37aa"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7714), "Passion fruit syrup", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("292718e9-2ce7-4176-8f3d-6d1bd32660a8"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7698), "Advocaat", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("11450eb9-9f7f-4c53-af81-cb15d350e830"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7685), "Erin Cream", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8b1677d1-dd0c-4156-9e92-be83c0013c68"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7661), "Sambuca", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bf47a13f-af5c-4b5b-876a-fb395fa464c2"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7644), "Chocolate liqueur", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f2c7509d-af39-4c3b-9f0c-e32702613d95"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7624), "Guinness stout", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c3b73107-d464-40fe-b3b8-fd4f93940228"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7573), "Ale", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f34eff98-ad02-47f5-a5c2-25203878e586"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7559), "Goldschlager", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e60995e5-1ac9-4340-a9ec-025a8b613457"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7547), "Irish cream", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bd550597-5e9e-4339-9d34-3d1dd6017a76"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7531), "Pisco", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("089753f5-7667-4971-9269-ccf72f000256"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7517), "White rum", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5e8b1eff-98fa-44a0-a5b7-9ad746033a9f"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7496), "Dr. Pepper", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("03a9f5b4-e453-49fc-8299-db620a8e264f"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(7869), "Peppermint schnapps", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1901ea35-f610-4365-a4b6-245c2d202fd3"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9159), "Blackcurrant squash", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9fa7e45b-8c55-411c-9ef0-c309167c327a"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(852), "Tonic Water", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4e160ced-bd33-4ab6-b787-d53e799a553a"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9229), "Pepsi Cola", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("afbf8eaa-18e8-49b6-8eb5-cec255c5487a"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(669), "Maraschino Cherry", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7458a90c-c229-40b1-97da-9d618dfc7218"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(654), "Salted Chocolate", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4b2e5d2e-95f2-4858-80c7-41aa728038cf"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(641), "Chocolate Sauce", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fb29be06-1d69-4dfc-8451-8520d822e2f6"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(623), "lemon", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fa72a141-fa0d-40fc-a077-cbcc09afc3a2"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(605), "Fresh Lime Juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bf55a6da-689f-40df-8242-2c9a913f4d48"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(582), "Fresh Lemon Juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9a99824c-436c-4219-aae3-0b0f6a73a631"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(566), "Egg White", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0259e6b1-e326-4dc2-b96b-1c6c3cb9b645"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(547), "Cranberry Juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4c4b010a-6a56-4452-9a4c-7c4bd2f85dac"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(683), "Blackberries", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("31dce91f-c548-46f5-9c75-cdc775fcc364"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(525), "Mini-snickers bars", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("49f729de-3065-4b53-80bc-ff4fb94c5f8a"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(501), "caramel sauce", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bc3193ed-762f-4e2f-b23c-72a72aa59c5a"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(489), "Whipped Cream", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("05215af0-9b42-4ef7-ae5b-3668bd2532c9"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(469), "Vanilla Ice-Cream", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("57886385-8bac-4641-a9c2-59fc17214bd3"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(452), "White Rum", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("960160df-f8c4-4414-8483-3ec923f6931b"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(438), "Lillet Blanc", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("247c07b9-c046-41c8-83e3-792a86f3dfb1"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(421), "Tomato Juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9208b453-2cd5-4517-bf86-237987e769f0"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(405), "Agave syrup", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("53e14317-7475-4f72-8e19-7983ac35e8b6"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(389), "Soda Water", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("39044155-f67b-4976-a46c-6ca9e621daf3"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(513), "chocolate sauce", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a7d6a4fc-0c09-43d3-89d2-fd3465ba31d5"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(788), "Gold rum", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0a1b452b-094d-4b4e-a7a7-86917cd0b330"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(808), "Pernod", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("54e86871-9880-4425-a544-105555cf748d"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(830), "Ginger beer", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0ea2bed6-83cc-42d5-ac43-5610ad3b12ca"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(1189), "Islay single malt Scotch", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8d0a37d0-be0d-4e98-99dd-72ed2c7c98fe"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6964), "Fennel seeds", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("79faca8b-e51e-49c5-9193-d145a67cf6b9"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(1177), "Ginger Syrup", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b3d8100d-7bc5-4fab-aebb-4f4ff31e230c"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(1162), "Honey syrup", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9fe859ab-96fd-43d4-ae74-727b9482b13a"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(1115), "Blended Scotch", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f3ccdf70-3c61-4947-b73b-c43cf43e2baa"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(1092), "Irish Whiskey", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9db339bc-db7a-46dd-88cf-0867f7fd3a06"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(1077), "Hot Chocolate", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("61c3e46b-7d5b-48b6-995b-43b9390af2ac"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(1060), "Rosso Vermouth", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3eab2e87-1d67-4b3c-a941-fc6b8a143b60"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(1048), "Elderflower cordial", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("db819638-cf20-43bd-96fc-78459eacc9f3"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(1030), "Passoa", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0f96efd9-a0d9-4182-914b-86b00c42369c"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(1016), "Sweet and Sour", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4e7625cf-5115-4cb3-b8db-6ff3c37416dc"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(996), "Jagermeister", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("edb5d5f3-2b36-49fb-9bc8-605945472085"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(983), "Bailey", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9b788d54-d354-4a94-9550-7b49bd5e2559"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(954), "Grape Soda", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d4f7b195-dbc1-47ad-9843-54c347177e7e"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(929), "Orange Bitters", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("797dccde-bcdc-4f2a-b806-38ba1863f507"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(912), "Orange Peel", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2aff8260-40df-481d-94bb-c162c2253375"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(899), "Lillet", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f3b2e909-125d-4096-bd86-00dc352d9a6f"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(879), "Mezcal", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c2c231d1-c2f5-462a-915d-4987cb1ebf5e"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(865), "Rosemary", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("56047ced-e590-4a35-949f-27907c881302"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(338), "Sugar Syrup", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f89c0c26-f3b7-4a15-9f76-ee4e8f20529f"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(323), "pineapple juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1c42fcf1-5894-43f5-8cf6-5d947872620b"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(310), "Raspberry Liqueur", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("01117d8e-e895-4b8b-9b33-68065a523311"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(291), "Ginger Beer", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("398b2a31-3acf-4661-9a8a-3848037b8400"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9762), "Agave Syrup", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9769ccc4-7830-47f6-a7e1-814ac90cb0a8"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9750), "Lemon Juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("94c083a0-626a-46dc-9488-2184d2c8d2d2"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9734), "Cherry Grenadine", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c93e1963-aaf2-4831-9182-ac4f0d162342"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9721), "Triple Sec", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c2498032-c239-4529-9ba2-0ce06328ff3c"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9697), "Raspberry vodka", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f1e6ea51-5424-43c5-abfe-9228b2850de0"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9668), "Maui", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("80209991-74a8-42d1-85b1-bfd19803fda6"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9645), "Blueberry schnapps", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3d7b8991-8389-4f02-bbf2-6e5577007ddd"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9618), "Gold tequila", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("018a7295-da57-4171-86bc-20dc14ecab2d"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9598), "Lime juice cordial", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("70fd76a1-4161-481d-89c0-4ccead944481"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9577), "Rumple Minze", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("de1bf6c3-b9f2-440f-890b-e29d520b4b3d"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9527), "Corn syrup", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2e776912-b983-4e5e-937c-1010e6f3c010"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9493), "Mountain Dew", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b403c270-6c87-4909-9581-56b462f077b3"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9480), "Melon liqueur", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d79dda9c-6809-4b2f-b2ab-b7a67978a012"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9424), "Limeade", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("23d28c36-bcd4-4e9e-bd33-0222c9142bd9"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9351), "Tennessee whiskey", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5bfc5053-9284-401e-be62-b4b12777c897"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9327), "Whisky", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("94f49ed4-ba14-49e0-8bb2-b20bb8be6d27"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9299), "Absinthe", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("73116424-e241-44ce-b682-d7bd20413801"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9275), "Cream of coconut", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3ab2b38f-bb75-4441-a171-21570071c3c3"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9255), "Orange Curacao", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("32ea6736-5311-4baf-8d42-1b1ba1b77779"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9785), "demerara Sugar", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fe4ee333-df76-419a-b77c-597662e6a03e"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9174), "Zima", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("164ebd5c-2329-4662-9925-b0083cf651d3"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9804), "lemon juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("72ecfe06-a7d4-4398-86ae-acaf690b7f31"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9832), "Olive Brine", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a756b42a-4257-4a2a-b847-1a9b3ef4c320"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(279), "Dark Rum", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("49ac8f93-cb79-4620-83de-2ebb30c0fed0"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(265), "Creme de Mure", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5dfd1606-336f-41b7-a1ae-49905c4635d9"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(249), "Prosecco", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9234ff91-2bd8-4e6f-9c16-5786690e6772"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(236), "Pineapple Juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1a91ca90-3c18-49fe-a6de-2a253bfa7535"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(214), "Coconut milk", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d94f6a87-747f-46df-8d61-83542800d7bf"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(179), "Maraschino Liqueur", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("59bfc3c6-6eac-4c26-8029-099e77d48ad7"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(166), "Grapefruit Juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("874f59ec-0ec5-4c19-9f82-d79c9745f5cc"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(144), "orange juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5e82e34f-1ffa-48e0-b75a-a1f5cf28261a"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(107), "Egg Yolk", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3f34239c-d957-4434-be25-7b4599919cc1"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(86), "Orange Juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("85cf814c-69e7-414b-9c16-9c1523ab740e"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(73), "Apricot Brandy", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d600ecc9-e69e-4cf7-9720-66d8ae1e54e2"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(47), "Peach Bitters", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1100ad48-e4a0-4b8a-900d-d9139bcfef91"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(34), "gin", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("512814dd-cb3c-4598-97f7-b2e345b09764"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9997), "Lavender", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f88be25c-5410-4be6-b1ea-a9071e2d3953"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9901), "Pepper", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("011ed8f9-48bc-4593-9a72-5386cd42cc0c"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9886), "Angostura Bitters", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("16ad006e-013b-45e4-b3a3-a7d10e00fe88"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9874), "St. Germain", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("631c964a-b587-4ce1-b6eb-e0b7e8f7dac3"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9862), "Pineapple Syrup", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("de5404b8-6729-45e6-8f4e-459ba6761862"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9849), "Lime Juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("42436e52-9249-448f-b088-9765bfdc484b"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(9816), "maraschino liqueur", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fc26c2f2-633f-454d-96b6-2188b948db60"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6950), "Johnnie Walker", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ad1c9214-1c9d-4786-9707-0c98c940f49c"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3581), "Light cream", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a39b0672-f90f-493f-be32-53e260934fc6"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6915), "Peppermint extract", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4d719186-b002-4606-a785-1aca7938342e"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4048), "Tomato juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c027f073-430f-49ad-be32-2f1ba6228500"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4025), "Coffee liqueur", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d1506e43-69f4-435a-820d-1938268642c3"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4010), "Carbonated water", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e7f2ec29-21de-4467-8179-24a86234b9a9"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3991), "Banana", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f29c709f-3cb3-4e00-b4d0-46b2d0fa1f2e"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3973), "Scotch", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f79f61f7-3e31-4be4-b187-a97429984f4e"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3957), "Bitters", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("33c41598-a3f1-458c-b742-3d6cccfa4d91"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3940), "Grand Marnier", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b57d0138-00ad-44dc-81d9-18ebeec39d6e"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3924), "Green Creme de Menthe", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("23d46174-429e-4db6-9c23-7719a03e7d51"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4062), "Tabasco sauce", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("876433cc-713d-416d-9ce6-d6aeaf999c81"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3911), "Champagne", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("29d644bf-0f01-4a56-87ca-f80fc5c063b2"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3883), "Wine", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4b0f2ca4-d490-41df-a304-ad1667beb5ab"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3866), "Orange", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5e334218-3c08-4d85-81a9-2a39d7fc4d73"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3812), "Applejack", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7e20defd-66a5-4d15-b610-148e9dd20b48"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3795), "Apple brandy", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("85473459-6e6a-4d2f-9596-a632509cf93e"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3781), "Whipped cream", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ef21d188-bea2-4078-8325-0587040e78a9"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3768), "Tea", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("65e1ffe8-0d3e-4635-b519-2ac21ec4c7f6"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3754), "White Creme de Menthe", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6e586d29-9b51-4287-89a4-d5438824f379"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3739), "Club soda", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a8b8172b-b61e-4442-b052-8d65d4318ae5"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3896), "Benedictine", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f5085342-1d1c-41cb-9faa-2aa8045a6fcc"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4179), "Celery salt", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3b8b8eb3-1139-4d40-8113-baf3a7fd1997"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4199), "Worcestershire sauce", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e69e1dea-c4b7-493f-9c13-c7936ce3b2a9"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4217), "Blue Curacao", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("630b5e0f-805e-4488-b3fb-cf3dec22afd1"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4737), "Strawberries", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8041f906-cfd6-499d-a323-35b47dd05fcb"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4675), "Orange spiral", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e3f40d79-22a6-4c76-815b-3f19349bca8a"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4657), "Tonic water", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9be2efe0-acec-4ebf-9b74-41b915a8cc95"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4637), "Pineapple", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fe29e596-8be7-4f2f-b1ca-25900dc0df3e"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4592), "Sugar syrup", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("546a0789-5146-4f6b-944e-d55371a5f930"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4556), "Dubonnet Rouge", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8ac078c2-9830-43a9-9aa6-235c63ba6609"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4489), "Chocolate ice-cream", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6a56dad6-e0a5-480a-b3e6-3964530016f7"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4471), "Port", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0e0a209a-8191-430c-8222-048ad22f970b"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4454), "Cherry brandy", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9e734024-8175-4751-b459-1fc6230c8c4f"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4439), "Cognac", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("999b9456-21f1-44dd-bc27-6083708c20b6"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4422), "Egg yolk", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f92c6db0-ecff-4301-a006-33d811ce7a6d"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4393), "Cachaca", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("17d64f77-ae38-44d4-a2fd-f95cd4234d0f"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4369), "Egg", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a09b23d6-1721-4e07-b62c-0b87abf32f8c"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4346), "Grenadine", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("55a8cb0d-6fe3-45ff-808b-ddb3311ef99b"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4302), "Maraschino liqueur", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4394064b-a979-494e-b8b5-a2f3fb7efa49"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4275), "Orange juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f4dbe90e-1cab-4e56-9a13-5461d6f29371"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4261), "Tia maria", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("167abf6f-5788-4230-8689-585607262025"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4248), "A�ejo rum", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e2f972dc-bbd5-4e54-bf14-a68bc76142b0"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4230), "Lemonade", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5e18c959-1d67-4fe5-bbbe-d144b048bc75"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3716), "Egg white", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ea2a2d72-5487-4a5e-a092-db8a7873b4f3"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3704), "Kahlua", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5a7419bb-1218-40c4-834e-4c66c91ccbcb"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3691), "Dark rum", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4b058ab6-0938-4895-b86e-bd1678f64820"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3675), "Kummel", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("54f1957d-fd1e-4b5b-9a93-5907872d1b59"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3257), "Cherry", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("291f0a3c-d774-422b-990d-93f8043cb4f7"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3195), "Powdered sugar", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("467d2a57-b358-497c-808c-2808fde7fb50"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3181), "Blended whiskey", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("28620e17-042a-49ae-a4f4-84af51ac7573"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3161), "Sweet Vermouth", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("635d6464-5277-42cf-904d-82af7dafaee9"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3148), "Campari", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0db9c818-8b38-4707-9476-e8e0c249a00d"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3133), "Coca-Cola", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8dad35e0-add9-4e21-96d0-b87936403dab"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3120), "Lemon", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("431c22a5-2e2c-4b8c-b896-eb463dd353c3"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3103), "Tequila", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2cbfcce2-cd49-4557-ab75-fcd3996201e6"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3091), "Gin", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4f1d94b1-914b-4e58-873f-6dfbd358ba75"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3074), "Vodka", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9f05015e-7f29-4541-86f8-29eae66ae6fa"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3057), "Water", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4bb64abe-87f8-4209-9e99-36d030a737ff"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(2973), "Angostura bitters", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("26654cd4-7d64-48a1-bca9-0a4bfb350a04"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(2959), "Bourbon", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cdda1244-1ad9-41f9-b6cf-91e3e431389f"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(2872), "Soda water", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3d34ba9a-b1e5-414e-b6a4-aef7a5a7e837"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(2859), "Mint", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c2987759-90ac-48c1-8734-dbf1c37f7e9d"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(2836), "Sugar", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bb24148c-8836-49f3-8418-8dffefe5ebd4"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(2815), "Lime", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bab4b242-9433-4e26-bc6e-2c23669d67f2"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(2088), "Light rum", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("064fe1e6-c9b7-4d09-95ca-0e13e0d5340b"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(1204), "Falernum", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d42513e9-ee54-421c-a348-d4dbdb40d9fb"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3276), "Dry Vermouth", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("09cb55d0-cfe6-4b86-a744-4e5bbd1fe659"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4766), "Heavy cream", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d9dc21ce-c223-4e64-9855-6661ba3f40d4"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3292), "Olive", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("95b35996-63c2-434c-a49c-cebef05085e6"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3325), "Lime juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("19b06e4a-d2cc-41bf-904d-193dc3b9aa38"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3657), "Blackberry brandy", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("797480f5-6422-4f97-9f39-dc9a246d937b"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3639), "Pineapple juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c963941e-45aa-4702-a129-2f55ac5e766c"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3625), "Lemon vodka", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fe08d839-f549-42db-96a1-da2843a5d8f3"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3609), "Brandy", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c776100c-b7e7-41a3-a27e-529b6beb757e"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3593), "Nutmeg", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a39ee803-fe08-49fa-9d8b-7efd1abe265e"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3568), "Creme de Cacao", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8d0aea9e-75b3-4f71-81ec-9bcb4446279d"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3551), "Lemon peel", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8867c41a-b6e3-4e45-851f-6094660c6da3"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3537), "Yellow Chartreuse", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cd3e9c84-706b-467e-9583-1f7b4b84febd"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3484), "Orange bitters", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("90833928-5662-4543-9dee-0793e5cc126c"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3470), "Sloe gin", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("145a34dc-29ad-48cc-96cd-4504cf5d273d"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3455), "Amaretto", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a6f170ab-620a-4c0c-917f-2ae2f68b294b"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3442), "Southern Comfort", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("824a124e-fff7-4569-aa8b-456a9bbfbeb9"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3428), "Lemon juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fa293387-817c-45e6-9ec7-6e55f922006e"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3411), "Apricot brandy", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("12049964-57c7-47b5-9c9e-9e298b70e15c"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3395), "Ginger ale", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5f163ccf-3696-4bbf-b174-bcfe92636b18"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3379), "Orange peel", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cf0c299f-da86-41d9-97ce-d538b1195421"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3367), "Maraschino cherry", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dc6d08f6-2dca-4e9e-8904-131b58911585"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3354), "Ice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a68cb7be-2bb7-4eb9-8ae3-9b4ac4247421"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3337), "Salt", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0cad1498-ca27-408d-87dd-29fccbaeb17c"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(3312), "Triple sec", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d0d9d33c-0ad4-4468-a37a-2a1616d47e88"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6934), "Coconut syrup", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6658392c-c68d-4c54-b9a9-0e15d3518824"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4793), "Galliano", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("04fc57b1-7441-4692-b97a-ea9f3fa298d6"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4839), "Peach brandy", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1d52d6e2-646e-4fcf-aa4a-91df9ebf76bf"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6469), "Baileys irish cream", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("35d7eaa0-3a76-4c6e-a429-74dbdfc39008"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6456), "Ouzo", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c3d80ecf-80cd-47ff-94f1-6abf7ce5dec0"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6438), "Sirup of roses", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7c292441-1dd7-41f5-822c-e343602b36d7"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6388), "Peach Vodka", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5efe040d-fb64-441c-b302-7c9dfb85cdca"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6370), "Cranberry juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a61ec5a4-c2eb-491b-a6fa-c04213180a28"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6357), "Peach schnapps", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("65caef3d-b266-4a58-ab47-ca6f26c6f732"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6340), "Absolut Citron", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0c0dcdf2-9a92-4c47-80a2-f2557a34e50b"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6319), "Espresso", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d1aa7e3d-c21b-4cdd-b534-697ebffe6bfd"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6489), "J�germeister", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e923f6cc-912e-488f-a300-c35040463566"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6290), "Marshmallows", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("77f38b44-45fb-441d-8b40-c35cba89f858"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6264), "Vanilla extract", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("348fca82-8ff8-4a9b-bb47-c5b1ac23e095"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6251), "Butter", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c6577407-0260-48fe-be09-b20c7db78238"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6235), "Vanilla", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("546c37cc-38e0-4d6a-9c6a-f3ca0664a6b7"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6213), "Cinnamon", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("eb74bd39-c032-4de6-95ef-b88d2a61eb27"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6200), "Chocolate", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("909ad291-18c7-4dae-a5fa-5de1bedcb292"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6184), "Cornstarch", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("764b52e9-3c07-40cf-8f17-9f0da0e67788"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6168), "Cocoa powder", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0cf133c5-9795-484c-89ed-6740c4c1fb7f"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6130), "Papaya", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("28c340ea-315a-4a4b-85bc-3f0c2faccbe2"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6277), "Half-and-half", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8ec7b9a3-a495-40ab-a0f9-7f95ecb22474"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6504), "Coffee", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8702bbeb-b7b4-4457-a79c-17a6018f69f4"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6517), "Grain alcohol", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2fb4ee95-d6d9-46fb-a494-b3d1b99ff903"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6531), "Spiced rum", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ab9e491b-1b32-4739-9b2e-d07196b6ff55"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6896), "Cranberries", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("11c66825-b851-49cc-a2d3-4ff8a5169a3b"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6882), "Caramel coloring", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a24e039c-8136-412c-8ab0-68342fd7c6b2"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6851), "Marjoram leaves", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1efb1594-6679-45f2-ac98-16227d1adc75"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6836), "Allspice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3639b766-5eff-4ec2-8fc7-1be469381026"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6823), "Almond", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("efbe6734-c6df-4395-a5db-5aad2220ca0a"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6807), "Angelica root", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("981abe11-76af-4ade-8807-59866d26883b"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6750), "Glycerine", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1f19ff52-b525-49ff-a388-891ae2ce5ca7"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6734), "Food coloring", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3818d1a2-6d7e-4038-8cf0-ee7e39d9c000"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6719), "Almond flavoring", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("feec45c8-2b71-4739-b6e3-529a6b5f3cef"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6706), "Apricot", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("002a6ca3-24f6-4bc1-8bee-3654df7101a1"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6690), "Wormwood", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c12748e6-aaf7-4b34-98d1-940a3f5e2995"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6678), "Licorice root", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cbc9b3a4-3b8f-49e6-b42c-8f93b2dd0b1b"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6665), "Anise", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ed0e0b1c-adb5-4452-9723-f2c9b19d20e6"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6647), "Condensed milk", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("990cd24a-9809-4b58-98be-e15580efbc0e"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6627), "Whipping cream", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("d9b3f38d-7862-4d35-8e0b-70e6722c671c"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6610), "Coriander", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("37a8545c-0f86-4706-b357-454e90267de8"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6586), "Black pepper", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("be638e10-fd7b-4191-8132-55da972b1f3c"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6572), "Cloves", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e7248e9e-79b3-4d13-b28b-fb02903d92ae"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6559), "Cardamom", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7c46db23-30e9-4b5b-9935-26305150a5c6"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6117), "Kiwi", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bec7058d-3045-4dbe-b0b4-768481a217ad"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6101), "Grapes", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("4e662c0a-4b99-446a-aa3a-387d7d6bf78a"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(6084), "Berries", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c0ac7f0e-8103-4b6d-846c-f6ba642b93e8"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5945), "Cantaloupe", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("5f7c7087-de5b-45ed-b18e-ab39e98562ba"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5349), "Anisette", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0c3f2c7d-71be-4997-b626-44ac8fece16e"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5326), "Curacao", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("417e3764-ded4-428c-a80c-ddbce57f7c0f"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5304), "Peychaud bitters", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("73003d79-7ede-487d-b52f-f83cf6d28ba8"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5288), "Ricard", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("122fa638-83f9-4727-9e11-0393a6b6d3dd"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5256), "Lime peel", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("178bfe80-475c-44e8-840c-c274ade272be"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5241), "151 proof rum", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("dba37dd7-8f94-4c74-aa24-768d3453f324"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5223), "Milk", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a100e2ec-50af-4be5-a2e4-3997d57dc139"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5207), "Rum", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("cbfdfce8-68e9-44c4-a854-d38ed7c76ba6"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5168), "Lemon-lime soda", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b6338ac5-ec3b-4b26-9592-d19f2a81fad2"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5138), "Lime vodka", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bb868542-12db-4550-ab87-1749a39a6c77"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5125), "Coffee brandy", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ca894860-3e66-409e-aba6-e4cd613f5087"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5107), "Sherry", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("38a841ea-2714-4178-bb20-7767e1cde9dd"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5092), "Raspberry syrup", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("bdfc8e59-c800-4cae-af87-0c3bdd74b4c7"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5003), "Red wine", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f7123182-7258-4ce8-973f-e9aa203ec55b"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4981), "Grapefruit juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("af6cca06-4c3f-4c83-87ad-079c20944ab6"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4947), "Orgeat syrup", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9c09e87e-ce6a-4a02-b9ed-b64b1041de99"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4917), "Drambuie", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b6b986de-d874-4612-b89a-aadfa31a659e"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4880), "Green Chartreuse", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6b10ef22-7d5c-4a89-ae1b-6b3c0c883a6c"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4855), "Sweet and sour", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("b59cfa44-a54d-489a-b780-e110382ac24f"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5376), "Cointreau", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c0d51b2f-e183-492f-94d0-1387e993bc0f"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(4826), "Irish whiskey", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("de069078-a585-4888-9711-dcccfc5fa21a"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5411), "Strawberry schnapps", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0803e776-f124-45c3-8af6-b18c38748011"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5520), "Maple syrup", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("31f5b444-1ed1-41e2-9848-fd5714edf720"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5931), "Aperol", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("673b72bd-feae-4f76-9575-30fd6a17097b"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5911), "Cayenne pepper", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6a0c4e27-97dd-4c3f-a078-503bcfa64855"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5895), "Ginger", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8e9c0111-ed2d-45be-b75f-73a444b2323e"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5878), "Mango", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("508abeb2-cc84-46a6-a0ae-020f093d886a"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5851), "Asafoetida", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("67e7c4a7-fbd4-4e21-9eac-69fe3ce39183"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5832), "Cumin seed", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("abeeba9b-c96d-46b1-951e-bcbf5666eb11"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5772), "Mint syrup", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9a343eef-5bdf-4973-bff9-0ac9743963fb"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5756), "Fruit", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("e547da79-4292-45cc-8d66-012611913ce2"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5740), "Fruit juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c1eb8ce9-7f56-42e7-ae5d-129fb39a8127"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5723), "Apple", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("617e6148-e5dd-4c60-ac38-4195154bd1de"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5703), "Chocolate syrup", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2d4628ef-f7ab-42e1-ba09-71a0e04ba09a"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5686), "Honey", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9eb4fe9c-1dfc-4e55-a6e2-2196214a4ffb"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5672), "Yoghurt", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ec5a03bd-ba42-44d5-bc85-91c65b84b202"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5644), "Passion fruit juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("c6b4e3fb-787a-46a6-ac7a-09af206be05b"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5630), "Carrot", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8915aaab-aa47-4dd3-b67f-0b9864f8a7f0"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5617), "Apple juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1fe79c47-e6ee-4171-a036-13affbc15dd3"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5603), "Cream", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8f0d18f9-a2cb-409f-8bd1-4f1782e4e4f0"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5570), "Grape juice", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("0fcd16c4-6ee0-4fa2-8267-f4095c30a83c"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5539), "Creme de Cassis", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("da37b8ad-f0b8-4548-a8ab-ddc4ba5e865d"), new DateTime(2021, 5, 18, 17, 40, 58, 930, DateTimeKind.Utc).AddTicks(5459), "Anis", null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6894e23b-a784-408a-88dd-42ac77e279da"), new DateTime(2021, 5, 18, 17, 40, 58, 931, DateTimeKind.Utc).AddTicks(1218), "blackstrap rum", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cocktails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Ingredients",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Name");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Beer",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Cocktail",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 394, DateTimeKind.Utc).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Cocoa",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Coffee / Tea",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Homemade Liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Milk / Float / Shake",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Ordinary Drink",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Other/Unknown",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Punch / Party Drink",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Shot",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Soft Drink / Soda",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "151 proof rum",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "7-Up",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Absinthe",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Absolut Citron",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Absolut Kurant",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Absolut Peppar",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Absolut Vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Advocaat",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Agave syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Agave Syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ale",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Allspice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Almond",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Almond flavoring",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Amaretto",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Angelica root",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Angostura bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Angostura Bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Anis",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Anise",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Anisette",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Aperol",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apfelkorn",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apple",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apple brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apple cider",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apple juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apple schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Applejack",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apricot",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apricot brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apricot Brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Aquavit",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Asafoetida",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "A�ejo rum",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Bacardi Limon",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Bailey",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Baileys irish cream",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Banana",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Banana liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Beer",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Benedictine",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Berries",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Bitter lemon",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Black pepper",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Black Sambuca",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blackberries",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blackberry brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blackcurrant cordial",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blackcurrant squash",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "blackstrap rum",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blended Scotch",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blended whiskey",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blue Curacao",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blueberry schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Bourbon",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Brown sugar",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Butter",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Butterscotch schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cachaca",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Campari",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Candy",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cantaloupe",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Caramel coloring",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "caramel sauce",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Carbonated soft drink",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Carbonated water",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cardamom",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Carrot",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cayenne pepper",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Celery salt",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chambord raspberry liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Champagne",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherries",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherry",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherry brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherry Grenadine",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherry Heering",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherry liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate ice-cream",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate milk",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "chocolate sauce",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate Sauce",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cider",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cinnamon",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cloves",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Club soda",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coca-Cola",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cocoa powder",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coconut liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coconut milk",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coconut rum",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coconut syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coffee",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coffee brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coffee liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cognac",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cointreau",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Condensed milk",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coriander",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Corn syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cornstarch",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Corona",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cranberries",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cranberry juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cranberry Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cranberry vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cream",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cream of coconut",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Creme de Banane",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Creme de Cacao",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Creme de Cassis",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Creme de Mure",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Crown Royal",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cumin seed",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Curacao",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Daiquiri mix",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dark Creme de Cacao",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dark rum",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dark Rum",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "demerara Sugar",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dr. Pepper",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Drambuie",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dry Vermouth",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dubonnet Rouge",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Egg",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Egg white",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Egg White",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Egg yolk",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Egg Yolk",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Elderflower cordial",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Erin Cream",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Espresso",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Everclear",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Falernum",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fennel seeds",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Firewater",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Food coloring",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Frangelico",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fresca",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fresh Lemon Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fresh Lime Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fruit",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fruit juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fruit punch",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Galliano",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "gin",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Gin",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ginger",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ginger ale",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ginger beer",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ginger Beer",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ginger Syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Glycerine",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Godiva liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Gold rum",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Gold tequila",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Goldschlager",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grain alcohol",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grand Marnier",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grape juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grape soda",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grape Soda",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grapefruit juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grapefruit Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grapes",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Green Chartreuse",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Green Creme de Menthe",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grenadine",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Guava juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Guinness stout",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Half-and-half",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Heavy cream",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Honey",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Honey syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Hot chocolate",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Hot Chocolate",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Hot Damn",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Iced tea",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Irish cream",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Irish whiskey",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Irish Whiskey",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Islay single malt Scotch",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Jack Daniels",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Jagermeister",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Jello",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Jim Beam",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Johnnie Walker",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "J�germeister",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kahlua",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kirschwasser",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kiwi",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kiwi liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kool-Aid",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kummel",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lager",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lavender",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "lemon",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "lemon juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon peel",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon-lime soda",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemonade",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Licorice root",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Light cream",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Light rum",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lillet",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lillet Blanc",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime juice cordial",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime peel",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Limeade",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Malibu rum",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mango",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maple syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maraschino cherry",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maraschino Cherry",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "maraschino liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maraschino liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maraschino Liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Marjoram leaves",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Marshmallows",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maui",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Melon liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mezcal",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Midori melon liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Milk",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mini-snickers bars",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mint",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mint syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mountain Dew",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Nutmeg",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Olive",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Olive Brine",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange Bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange Curacao",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "orange juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange peel",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange Peel",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange spiral",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Oreo cookie",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orgeat syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ouzo",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Papaya",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Passion fruit juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Passion fruit syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Passoa",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peach Bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peach brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peach nectar",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peach schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peach Vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peachtree schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pepper",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peppermint extract",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peppermint schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pepsi Cola",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pernod",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peychaud bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pina colada mix",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pineapple",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "pineapple juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pineapple juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pineapple Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pineapple Syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pink lemonade",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pisang Ambon",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pisco",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Port",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Powdered sugar",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Prosecco",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Raspberry Liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Raspberry syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Raspberry vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Red wine",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ricard",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Root beer",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Rosemary",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Rosso Vermouth",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Rum",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Rumple Minze",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Rye whiskey",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Salt",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Salted Chocolate",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sambuca",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sarsaparilla",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Schweppes Russchian",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Scotch",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sherbet",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sherry",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sirup of roses",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sloe gin",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Soda water",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Soda Water",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sour mix",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Southern Comfort",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Spiced rum",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sprite",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "St. Germain",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Strawberries",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Strawberry liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Strawberry schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sugar",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sugar syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sugar Syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Surge",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sweet and sour",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sweet and Sour",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sweet Vermouth",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tabasco sauce",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tea",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tennessee whiskey",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tequila",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tia maria",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tomato juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tomato Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tonic water",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tonic Water",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Triple sec",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Triple Sec",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tropicana",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vanilla",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vanilla extract",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vanilla ice-cream",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vanilla Ice-Cream",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vanilla vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vermouth",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Water",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Whipped cream",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Whipped Cream",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Whipping cream",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Whiskey",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Whisky",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "White Creme de Menthe",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "White rum",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "White Rum",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Wild Turkey",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Wine",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Worcestershire sauce",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Wormwood",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Yellow Chartreuse",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Yoghurt",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Yukon Jack",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Zima",
                column: "CreatedAt",
                value: new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3479));
        }
    }
}
