   M S B A M L   `   `   `  ����h  dST10391534_NicolBlack_RecipeBookGUI_POE_Part3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:ST10391534_NicolBlack_RecipeBookGUI_POE_Part3-ST10391534_NicolBlack_RecipeBookGUI_POE_Part3  5   	   A    ;ST10391534_NicolBlack_RecipeBookGUI_POE_Part3.RecipesWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Mlocal;clr-namespace:ST10391534_NicolBlack_RecipeBookGUI_POE_Part3     5   	     � Title$  Recipes Window��5   	   $	��800��6    $	��880��6-   ���#EFE8CB.��5	      �  � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $��* �6   .+�5   
   �� ���#4C2947$��0��6*   $��Stretch=�6:   .+�5      �� -   5         ��Name$ viewRecipesBtn��5      $��View Recipes��6-   $	��167��6D   $��39��6P   $��10q�6\   ���#4C2947
�������$��Perpetua)�5   =   $
��13.2(�6S   $
��Bold"�6c   �� 5      -   5         ��Name$ 
searchTBox��5      $��Segoe UI)�6*   $��11(�6@   $	��226��6N   $��32��6Z   $��10q�6f   �� 5      -   5        $ 	searchBtn��5      $��Search��6(   $	��100��69   $��34��6E   $��10q�6Q   ���#4C2947
�������$��Perpetua)�5   =   $
��13.2(�6S   $
��Bold"�6c   �� 5      -   5        $ 	DeleteBtn��5      $��Delete��6(   $	��167��69   $��39��6E   $��10q�6Q   ���#4C2947
�������$��Perpetua)�5   =   $
��13.2(�6S   $
��Bold"�6c   �� 5      -   5        $ backBtn��5      $
��Back��6&   $	��169��65   $��39��6A   $��10q�6N   ���#4C2947
�������$��Perpetua)�5   =   $
��13.2(�6S   $
��Bold"�6c   �� 5!      -   5        $ exitBtn��5!      $
��EXIT��6&   $	��167��65   $��39��6A   $��10q�6M   ���#4C2947
�������$��Perpetua)�5"   =   $
��13.2(�6S   $
��Bold"�6c   5#      �� 5&   
   $��1��6   $��10q�6%   .+�5(      �� -   5         ��Name$ Heading��5(      $��The Recipe Book��6%   $��Perpetua)�6?   $
��25.8(�6U   $
��Bold"�6e   $��Italic$�6w   �� 5*       �� Orientation$ 
Horizontal=�6   $	��Top=�62   $��10q�6J   .+�5+      �� $��Ingredient:��6   $��Center=�6.   �� 5,      -   5        $ ingredientsTBox��5,      $	��200��63   $��23��6?   $��5q�6K   �� 5-      $��	Calories:��6   $��Center=�6,   �� 5.      -	   5        $ caloriesTBox��5.      $	��200��60   $��23��6<   $��5q�6H   6S   5/      �� 51      $ 
Horizontal=�6   $	��Top=�62   $��10q�6J   .+�52      �� $��Food Group:��6   $��Center=�6.   �� 54      -
   5         ��Name$ foodGroupCBox��54      $	��200��62   $��23��6>   $��5q�6J   .@�55      �� $��Grains��6#   �� 56      $
��Milk��6#   �� 57      $��Fruits��6#   �� 58      $
��Eggs��6#   �� 59      $��Meat and Poultry��6#   �� 5:      $��Fish / Shellfish��6#   �� 5;      $��
Vegetables��6#   �� 5<      $��	Fats/Oils��6#   �� 5=      $��Legumes/Nuts/Seeds��6#   �� 5>      $��Sugar / Spices��6#   �� 5?      $��Dietary Supplements��6#   �� 5@      $��Non-alcoholic Beverages��6#   �� 5A      $��Alcoholic Beverages��6#   5B      �� 5D      -   5        $ 	filterBtn��5D      $��Filter��6,   $��94��6=   $��29��6H   $��5q�6T   ���#4C2947
�������$��Perpetua)�5E   A   $
��10.8(�6W   $
��Bold"�6g   5F      �� 5H      -   5         ��Name$ allRecipesLBox��5H      $	��484��6.   $��10q�6;   6G   5I      �� 5L   
   -   5        $ closeBtn��5L      $��X��6"   $��Right=�6.   $	��Top=�6J   $��10q�6b   $��Lucida Console)�6n   $��12(�6�   6�   5M      5N      