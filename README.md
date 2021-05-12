# ShopifyImageRepository

## How to set up
1. You will need Visual Studio community 2019
2. clone github to your local
3. run the app by using IIS Express, it should open up a page
4. you can select an image or images (has to be png or jpeg to display the image proprely)
5. save image

I made a connection to azure database as it most likely provide some security instead of my local database. Therefore, there is some image already.
As for Azure db, I made a stored procedure to insert into the database that will auto increment the ID. You can find it by going into 
1. Databases
2. ShopifyImageDB
3. Programmability
4. Stored Procedures
5. dbo.SP_Images


project made by: The Phi Nguyen
