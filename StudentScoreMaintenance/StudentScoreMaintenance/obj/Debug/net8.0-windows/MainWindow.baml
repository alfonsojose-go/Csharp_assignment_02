   M S B A M L   `   `   `  ����R  NStudentScoreMaintenance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:StudentScoreMaintenanceStudentScoreMaintenance  5   	   (    "StudentScoreMaintenance.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:StudentScoreMaintenance     5   	     � Title$  Student Scores��5   	   $	��381��6    $	��448��6-   .��5	      � $	��360��6   $	��Top=�6   .+�5
   
   �� $��Students List��6   $
��Left=�6(   $��	40,21,0,0q�6C   $	��Top=�6V   $
��Bold"�6n   �� 5   
   -   5         ��Name$ btnAdd��5      $��_Add New��6!   $
��Left=�64   $��
331,49,0,0q�6O   $	��Top=�6c   $��80��6{   $��1��6�   �� 5   
   -   5        $ 	btnUpdate��5      $��_Update��6$   $
��Left=�66   $��
331,90,0,0q�6Q   $	��Top=�6e    J� RenderTransformOrigin$ -0.139,0.235&�6}   $��80��6�   $��2��6�   �� 5   
   -   5        $ 	btnDelete��5      $��_Delete��6$   $
��Left=�66   $��331,130,0,0q�6Q   $	��Top=�6f   $��80��6~   $��3��6�   �� 5   
   $��Score Total:��6   $
��Left=�6'   $��
46,201,0,0q�6B   $	��Top=�6V   �� 5   
   $��Score Count:��6   $
��Left=�6'   $��
39,243,0,0q�6B   $	��Top=�6V   �� 5   
   $��Average:��6   $
��Left=�6#   $��
61,285,0,0q�6>   $	��Top=�6R   �� 5   
   -   5         ��Name$ txtScoreTotal��5      $
��Left=�6)   $��133,205,0,0q�6D    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��120��6�    �� 
IsReadOnly$
 True��6�   �� 5   
   -   5        $ txtScoreCount��5      $
��Left=�6)   $��133,243,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   $
 True��6�   �� 5   
   -   5        $ 
txtAverage��5      $
��Left=�6&   $��133,285,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $	��120��6�   $
 True��6�   �� 5   
   -   5        $ btnExit��5      $��E_xit��6"   $
��Left=�62   $��331,284,0,0q�6M   $	��Top=�6b   $��80��6z   6�   �� 5   
   -   5         ��Name$ lstbxStudents��5      $��30,43,133,180q�6T    �� SelectionMode$ Single=�6k   6�   5      5      