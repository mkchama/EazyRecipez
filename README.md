# EazyRecipez

README

Created for CPSC 481, University of Calgary
Group 02 - Michael Funk, Olufunke Ogunmefun, Junehyuk Kim,  Shude Li, Mohammad Chama

# Easy Recipez
A one stop cooking app for all your cooking needs. Allows users to view and create recipes for their favorite, or soon to be favorite meals. After creating recipes, users will either have a choice to share to other users or to simply save it to their personal collection.

## Basic Instructions
#### Searching:
On the top of most screens that list recipes, you can click on the search text field to find your desired recipe. Using a keyword will search through the recipes’ names, not the ingredients in the recipe. You can also hit the small x on the right of the text field to clear your search once it has been made. The x will only appear when a search has been made. Scrolling with the mouse is the way to scroll through the recipes. By clicking on any of the categories, it will proceed to the category page with all the recipes that belong to that category page. Searching in the category page will only show the recipes with recipes including the specific keyword that belong to the category page. The user can also switch from one category to another with another keyword, and it will automatically search when using the keyword search.

#### Home screen:
There are 5 categories that you can horizontally scroll through to access, clicking one will bring up a page with only recipes in that category.

#### Recipe View Page:
Once a recipe has been clicked, you will be taken to the recipe view page. There are a number of things that can be done on this screen. You can click on the arrow below the pictures to go through the pictures, or use your mouse wheel to go through them. You can also rate the recipe through the stars above the images by clicking on the stars depending on your rating you wish to give. You can scroll through the view, and also pull up a larger single page list of the instructions. At the bottom of this view you reach the comments in which you can make a comment on the recipe. The arrow button should bring you back to the page that you were currently on before.

#### Create/Edit:
The app allows users to create recipes through the create middle tab on the bottom. Once the user has recipes, they can edit their own recipes by finding them in the profile -> my recipes section.

#### Profile:
You can access your favorite recipes, as well as your own recipes to edit.

## Error avoidance

As a result of not having a database, and needing to hardcode many features, please follow these steps when wanting to complete a task to avoid any issues with the program. Also certain functionalities do not work as intended due to the lack of database, some odd interactions will be listed below. With the lack of database, any changes to the system (rating, favoritings, commenting, creating recipes, etc.) will be lost when exiting out of the system.

#### Create Recipe:
As of right now, when you click create recipe, it is set up to only work for one recipe for our demo which is the savory party bread. The image gallery will always select the same 3 photos no matter which ones you click. Once you click post, it will show up in my online recipes, and will now appear in the appetizer category. All fields must be filled out as well before clicking “post” will work.

#### Edit Recipe:
Categories are not updated when browsing through categories once you change a recipe’s category.

#### Searching recipes
Only a few recipes once searched actually allow you to click, these are the recipes that are shown from the keywords “salmon”, “steak”, and “sugar”. These words can either be searched in the Home page, or any of the categories that the recipes belong to. (Using “sugar” for dessert will come up with the screen containing a clickable recipe. However, you can still search and see other recipes in your search, they just will not be clickable. Most of the recipes do not have all the functionalities, so refer to the “viewing through full recipes” category for more information.

#### Clickable recipes:
There are few recipes that can be clicked. The list being:
“Lemon Garlic Salmon”, “Tuna steak”, “French Macaroon” “Tuscan Sausage” “Sugar Cream Pie” “Fluffy Pancakes”. Once one of these recipes have been clicked, it will go back to the category page of where it belongs, instead of where the user has last been.

#### Recipe View - Viewing through full recipes:
When viewing through the “clickable recipes”, not all recipes have all the functionalities. One main thing is that the back button of the recipe will redirect to the category page the recipe belongs to, instead of going back to the page the user has last been. Only the “Buffalo Chicken Dip” recipe will be saved to favorites. Other recipes will indicate with a heart icon being filled with red, but will not update into the profile page. All the recipes in the list can be commented as well as rated. As for viewing the instructions page, only the “Fluffy Pancake” recipe includes it. The voice icons/buttons on the instruction page do not do anything, even though the functionality is to read out the instruction. None of the pages have a comments viewing page (the arrow button beside the comment). 

#### Homepage/Category Pages:
Categories need to be scrolled horizontally. The appetizer category is cut off from the view and can be viewed fully when scrolling (using a mouse). It will still function without being seen fully, but in order for the user to see it fully they will need to scroll (using a mouse).
