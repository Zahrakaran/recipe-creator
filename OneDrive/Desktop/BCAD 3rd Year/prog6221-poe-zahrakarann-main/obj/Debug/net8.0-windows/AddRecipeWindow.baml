   M S B A M L   `   `   `  ����  RecipeCreatorWPFApp)    #RecipeCreatorWPFApp.AddRecipeWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
Add Recipe��5   	   $	��450��6   $	��600��6)   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ txtRecipeName��5      $��0��6)   $��2��66   $	��300��6J   $��10q�6V   $��Recipe Name��6b   6�   �� 5   
   -   5        $��Add Ingredient��5      $��1��6*   $��0��67   $	��150��6c   $��10q�6o   �� 5   
    �� DisplayMemberPath$
 Name��66   $��2��6O   $��2��6\   $	��400��6p   $	��100��6|   $��10q�6�   $	��Top=�6�   ��6   �� *Ingredients+6�   �� 5   
   -   5        $��Add Step��5      $��3��6$   $��0��61   $	��150��6W   $��10q�6c   �� 5   
   $��4��60   $��2��6=   $	��400��6Q   $	��100��6]   $��10q�6j   $	��Top=�6v   ��6   �� *Steps+6v   �� 5   
   $��Total Calories:��6   $��5��6+   $��0��68   $��10q�6H   �� 5   
   $��5��63   $��1��6@   $��10q�6P   ��6   �� *TotalCalories+6P   �� 5!   
   $��6��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $��Center=�6O   $��10q�6l   .+�5"      �� -   5        $��Save Recipe��5"      $	��100��6D   �� 5#      -   5        $��Cancel��5#      $	��100��6;   5$      5%      5&      