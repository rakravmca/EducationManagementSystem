   M S B A M L   `   `   `  ����  EducationManagementSystem1    +EducationManagementSystem.Views.StudentView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        � 	Resources  5         
LinkButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value  VioletGardientBrush �� EndPoint	 �� 
StartPoint
 � Color � Offset �� Self �� RelativeSource �� Path��%�  &	        &	 f    '��     7  '�� �    �� 5	   
   " ��6#   .�5
      ��  � �� 5      �� 5      " ��6&   .R�5      �� $��Normal"�6$   �� 5      5      5      5      �� 5       � ��
 ��  �6,    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��
 ��+��64   �� 5       �@�Cursor$
 Hand��6/   5      5      �� 5   
   $ 	0.504,1.5&�6:   $	 
0.504,0.05&�6O   .��5      � $
 #e1cdf9��6   $ 0Q�6+   � 5      $
 	#FFFFFFFF��6   $ 0.600Q�6-   5      �� 5!   
   " ��6   .�5"      ��  � ��8   6+   �� 5#       � ��$ 80��6&   �� 5$       � ��$ 10q�6'   5%      �� 5'   
   " ��6    5(      P� 5)       �@=�HasError . . �5*      ��  �@�ToolTip 60   �� # Z $2 ,(Validation.Errors).CurrentItem.ErrorContent�5+      5-      5.      .��5/      ]� -   5        $��StudentPanel��5/      .+�50   
   �� $	��Top=�6   ._�51      �  � Orientation$ Vertical=�6   .+�52      �� .��6   Student Information6-   �� 53      $
��Left=�6   ��64   �� $ AddStudentPopupCommand�.��6d   Add6i   �� 54      -   5        $��lvUsers��54   j   $ �� IsSynchronizedWithCurrentItem$
 trueY�6E   ��6   �� *StudentCollection+ �� View 55      �� 56      .P�57      �� $��Id��6-    �� DisplayMemberBinding 69   �� $ Id��� 58      $��	FirstName��6-    6@   �� $ 	FirstName��� 59      $��
MiddleName��6-    6A   �� $ 
MiddleName��� 5:      $��LastName��6-    6?   �� $ LastName��� 5;      $��	BirthDate��6-    6@   �� $ StringBirthDate��� 5<      $��Gender��6-    6=   �� $ Gender��� 5=      $��Phone��6-    6<   �� $ Phone��� 5>      $
��Edit��6-    �� CellTemplate 5?   "   �� 5@   &   .R�5A   *   �� $
��Edit��61   #��[  6�   ��6@   ��  �� ElementName$ lvUsers��$) #DataContext.EditStudentPopupCommand���6�   �� 6�   5B   '   5D      �� 5E      $��Delete��6-    5F   "   �� 5G   &   .R�5H   *   �� $��Delete��61   #��[  6B   6h   5I   '   5K      5L      5N      5O      5P      � 5Q   
   -   5        $��StudentPopup��5Q      $��Center=�6O   $
��Fade=�6�   ��6$   �� $ IsStudentPopupOpen� � PlacementTarget 6b   �� $ StudentPanel��.��5R      � $ 
Horizontal=�6   $��Center=�61   $��Center=�6N   $	��300��6i   .+�5S      �� 
����+��$��1,1,1,1q�62   ���#e1cdf9._�5T      �  � RowDefinitions 5U      �� 5V      $
��Auto �6,   �� 5W      $
��Auto �6,   �� 5X      $
��Auto �6,   �� 5Y      $
��Auto �6,   �� 5Z      $
��Auto �6,   �� 5[      $
��Auto �6,   �� 5\      $
��Auto �6,   �� 5]      $
��Auto �6,    � ColumnDefinitions 5_      �� 5`      $
��Auto �6/   �� 5a      $
��Auto �6/   �� 5b      $
��Auto �6/   �� 5c      $
��Auto �6/   �� 5d      $
��Auto �6/   �� 5e      $
��Auto �6/   �� 5f      $
��Auto �6/   �� 5g      $	��200 �6/   .+�5i      �� $��0��6    $��0��60   $��Student:��6=   $
��Bold"�6P   
���� ��6b   �� 5j      $��1��6    $��1��60   
���  ��$y�	Collapsed=�6N   .��5k      �� #!Please fill all mandatory fields.5m      5n      �� 5o      $��0��6    $��1��60   $��First Name:��6=   �� 5p      $��0��6    $��2��60   $��Middle Name:��6=   �� 5q      $��0��6    $��3��60   $��
Last Name:��6=   �� 5r      $��0��6    $��4��60   $��Date Of Birth:��6=   �� 5s      $��0��6    $��5��60   $��Gender:��6=   �� 5t      $��0��6    $��6��60   $��Phone:��6=   �� 5u      $��1��6"   $��1��62   $��3q�6?   ��6J   �� *CurrentStudent.FirstName+ �� ValidatesOnDataErrors . �� 5v      $��1��6"   $��2��62   $��3q�6?   ��6J   �� *CurrentStudent.MiddleName+ . �� 5w      $��1��6"   $��3��62   $��3q�6?   ��6J   �� *CurrentStudent.LastName+ . �� 5x      $��1��6"   $��4��62   $��3q�6?   ��6J   �� * CurrentStudent.StringBirthDate+ . �� 5y      $��1��6"   $��5��62   $��3q�6?   ��6J   �� *CurrentStudent.Gender+ . �� 5z      $��1��6"   $��6��62   $��3q�6?   ��6J   �� *CurrentStudent.Phone+ . � 5{      $��1��6$   $��7��64   .+�5|      �� $��3q�6%   $
��Save��60   ��6?   �� $ SaveStudentCommand��� 5}      $��3q�6%   $��Cancel��60   ��6A   �� $ CloseStudentPopupCommand�5~      5      5�      5�      5�      5�      5�      