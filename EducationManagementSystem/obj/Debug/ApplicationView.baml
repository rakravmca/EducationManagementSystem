   M S B A M L   `   `   `  ����T  PEducationManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:EducationManagementSystem.ViewsEducationManagementSystem.Views  5   	   [2clr-namespace:EducationManagementSystem.ViewModels$EducationManagementSystem.ViewModels  5   	   a5clr-namespace:EducationManagementSystem.HelperClasses'EducationManagementSystem.HelperClasses  5   	   a5clr-namespace:EducationManagementSystem.Views.Reports'EducationManagementSystem.Views.Reports  5   	   k:clr-namespace:EducationManagementSystem.ViewModels.Reports,EducationManagementSystem.ViewModels.Reports  5   	   /    )EducationManagementSystem.ApplicationView   5   	   7Views-clr-namespace:EducationManagementSystem.Views  A
ViewModels2clr-namespace:EducationManagementSystem.ViewModels  5   	   GHelperClasses5clr-namespace:EducationManagementSystem.HelperClasses  5   	   EReportViews5clr-namespace:EducationManagementSystem.Views.Reports  5   	   OReportViewModels:clr-namespace:EducationManagementSystem.ViewModels.Reports  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  ApplicationView��5	   	   $	��500��6!   $	��900��6.    � 	Resources 5
       �� DataType8   2EducationManagementSystem.ViewModels.HomeViewModel.   (EducationManagementSystem.Views.HomeView8   2EducationManagementSystem.ViewModels.UserViewModel.   (EducationManagementSystem.Views.UserView;  5EducationManagementSystem.ViewModels.StudentViewModel1   +EducationManagementSystem.Views.StudentViewF  @EducationManagementSystem.ViewModels.Reports.UserReportViewModel<   6EducationManagementSystem.Views.Reports.UserReportViewJ	   DEducationManagementSystem.HelperClasses.BooleanToVisibilityConverter   BoolToVisConverter  BoolToVisConverterReverse 	  Reverse  BoolToVisConverterCollapse 	  Collapse % !BoolToVisConverterCollapseReverse  
LinkButton �� 
TargetType �� Property �� Value �� 
TargetType	 �� Triggers
 P� Property P� Value  VioletGardientBrush �� EndPoint �� 
StartPoint � Color � Offset��%w  (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)(�� �     5      *, +)&	  �     &	 �     &	 �     &	     &	 0    &	 �    '�� =    7  �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      	  5   
   65   	  5   
    . 6W   	  5   
    . 6X   	  5   
    .  . 6o   �� 5   
   " ��6#   .�5      ��  � �� 5      �� 5       " ��6&   .R�5!      �� $��Normal"�6$   �� 5"      5#      5$      5&      �� 5'       � ��
 ��  �6,   	 5(      P� 5)      
 �@J�IsMouseOver . . �5*      ��  � ��
 ��+��64   �� 5+       �@�Cursor$
 Hand��6/   5,      5.      �� 50   
   $ 	0.504,1.5&�6:   $ 
0.504,0.05&�6O   .��51      � $ #e1cdf9��6   $ 0Q�6+   � 52      $ 	#FFFFFFFF��6   $ 0.600Q�6-   53      �� 55   
   " ��6   .�56      ��  � ��8   6+   �� 57       � ��$ 80��6&   �� 58       � ��$ 10q�6'   59      5:      .��5;      ]� -   5        $��	MainPanel��5;      .+�5<   
   �� $	��Top=�6   ���#e1cdf9$��0,0,0,1q�6<   ���#f3ebfd._�5=      �  � Orientation$ 
Horizontal=�6   $��Right=�61   .+�5>      �� $
��Bold"�6n   y�6   �� *IsAuntheticated+ �� 	Converter# [  .��6�   
Welcome:6�   �� 5?      $
��Bold"�6<   ��6   �� *UserDisplayName+6P   �� 5@      $��0,5,5,0q�6   $��Right=�6*   #��[ 6k   ��6A   �� *OpenLoginUserCommand+y�6�   �� *IsAuntheticated+# [ .��5A      �� Login6'   5B      �� 5C      $��0,5,5,0q�6   $��Right=�6*   #��[ 6s   ��6A   �� *OpenRegistrationnUserCommand+y�6�   �� *IsAuntheticated+# [ .��5D      �� 
Register6*   5E      �� 5F      $��0,5,5,0q�6   $��Right=�6*   #��[ 6A   ��6e   �� *LogoutCommand+y�6�   �� *IsAuntheticated+# [ .��5G      �� Logout6(   5H      5I      5J      �� 5K   
   $	��Top=�6   ���#f3ebfd$��0,0,0,1q�6<   #��[ 6V   ._�5L      ��  �� Orientation$ 
Horizontal=�6   .+�5M      �� $
��Home��6   $��2q�6(   $��Right=�63   #��[ 6y   ��6J   �� *RedirectToHomePageCommand+y�6�   �� *IsAuntheticated+# [ 6�   o� 5N       o� 
IsMainMenu . #��[ 6~   y�6)   �� *IsUser+# [ .@�5O      m� $��General��6   ��60   �� *GeneralViewModels+��5P      �� 5Q      .R�5R   "   �� #��[ 6�   ��6)   �� *Name+��6B   �� *DataContext.ChangePageCommand+ �� RelativeSource ��  �� AncestorType" ���6�   �� 6�   5S      5U      5V      o� 5W       . #��[ 6   y�6)   �� *	IsAdmin+# [ .@�5X      m� $��Administration��6   ��67   �� *AdministratiorViewModels+��5Y      �� 5Z      .R�5[   "   �� #��[ 6�   ��6)   �� *Name+��6B   �� *DataContext.ChangePageCommand+ �� " ���6�   �� 6�   5\      5^      5_      o� 5`       . #��[ 6   y�6)   �� *	IsAdmin+# [ .@�5a      m� $��Report��6   ��6/   �� *ReportViewModels+��5b      �� 5c      .R�5d   "   �� #��[ 6�   ��6)   �� *Name+��6B   �� *DataContext.ChangePageCommand+ �� " ���6�   �� 6�   5e      5g      5h      5i      5j      �� 5k   
   $	��Top=�6   
���   �$��0,0,0,0q�6:   $	��660��6T   ._�5l      �� ��6   �� *CurrentPageViewModel+5m      � 5n   
   -   5        $��
LoginPopup��5n      $��Center=�6K   $
��Fade=�6�   ��6"   ��  �� Path$ IsLoginPopupOpen� � PlacementTarget 6^   ��  �� ElementName$ 	MainPanel��.��5o      � $ 
Horizontal=�6   $��Center=�61   $��Center=�6N   $	��300��6i   .+�5p      �� 
����+��$��1,1,1,1q�62   ���#e1cdf9._�5q      �  � RowDefinitions 5r      �� 5s      $
��Auto �6,   �� 5t      $
��Auto �6,   �� 5u      $
��Auto �6,   �� 5v      $
��Auto �6,   �� 5w      $
��Auto �6,    � ColumnDefinitions 5y      �� 5z      $
��Auto �6/   �� 5{      $	��200 �6/   �� 5|      $
��Auto �6/   �� 5}      $
��Auto �6/   �� 5~      $	��200 �6/   .+�5�      �� $��0��6    $��0��60   $��User Login:��6=   $
��Bold"�6S   
���� ��6e   �� 5�      $��1��6    $��1��60   
���  ��y�6O   �� *
LoginError+# [ .��5�      �� " Username/Password are incorrect.�� 5�   "   6.   Please try again or �� 5�   "   #��[ 6[   ��6)   �� *OpenRegistrationnUserCommand+.��5�   &   �� 
Register6:   5�   #   5�      5�      �� 5�      $��0��6    $��2��60   $��	Username:��6=   �� 5�      $��0��6    $��3��60   $��	Password:��6=   �� 5�      $��1��6"   $��2��62   $��3q�6?   ��6J   �� $ UserName�G� 5�      -   5        $��MyPasswordBox��5�   &   $��1��6;   $��3��6L   $��3q�6Y   � 5�      $��1��6$   $��4��64   .+�5�      �� $��3q�6%   $��Login��60   ��6@   �� $ LoginUserCommand���6j   �� $ MyPasswordBox���� 5�      $��3q�6%   $��Cancel��60   ��6A   �� $ CancelLoginCommand���6m   �� $ MyPasswordBox��5�      5�      5�      5�      5�      � 5�   
   -   5        $��RegistrationPopup��5�      $��Center=�6Y   $
��Fade=�6�   ��6)   �� $ IsRegistrationPopupOpen� 6l   �� $ 	MainPanel��.��5�      � $ 
Horizontal=�6   $��Center=�61   $��Center=�6N   $	��300��6i   .+�5�      �� 
����+��$��1,1,1,1q�62   ���#e1cdf9._�5�      �  5�      �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,    5�      �� 5�      $
��Auto �6/   �� 5�      $
��Auto �6/   �� 5�      $
��Auto �6/   �� 5�      $
��Auto �6/   �� 5�      $
��Auto �6/   �� 5�      $
��Auto �6/   �� 5�      $
��Auto �6/   �� 5�      $
��Auto �6/   �� 5�      $
��Auto �6/   �� 5�      $
��Auto �6/   �� 5�      $	��200 �6/   .+�5�      �� $��0��6    $��0��60   $��Registration:��6=   $
��Bold"�6U   
���� ��6g   �� 5�      $��1��6    $��1��60   
���  ��$y�	Collapsed=�6N   .��5�      �� #!Please fill all mandatory fields.5�      5�      �� 5�      $��0��6    $��2��60   $��Initial:��6=   �� 5�      $��0��6    $��3��60   $��First Name:��6=   �� 5�      $��0��6    $��4��60   $��Middle Name:��6=   �� 5�      $��0��6    $��5��60   $��
Last Name:��6=   �� 5�      $��0��6    $��6��60   $��	Username:��6=   �� 5�      $��0��6    $��7��60   $��	Password:��6=   �� 5�      $��0��6    $��8��60   $��EmailId:��6=   �� 5�      $��0��6    $��9��60   $��Phone:��6=   �� 5�      $��1��6"   $��2��62   $��3q�6?   �� 5�      $��1��6"   $��3��62   $��3q�6?   �� 5�      $��1��6"   $��4��62   $��3q�6?   �� 5�      $��1��6"   $��5��62   $��3q�6?   �� 5�      $��1��6"   $��6��62   $��3q�6?   ��6J   �� $ UserName�G� 5�      -   5        $��RegistrationPasswordBox��5�   &   $��1��6E   $��7��6V   $��3q�6c   �� 5�      $��1��6"   $��8��62   $��3q�6?   �� 5�      $��1��6"   $��9��62   $��3q�6?   � 5�      $��1��6$   $��10��64   .+�5�      �� $��3q�6%   $��Register��60   �� 5�      $��3q�6%   $��Cancel��60   ��6B   �� $# CloseRegistrationnUserCommand�5�      5�      5�      5�      5�      5�      5�      