   M S B A M L   `   `   `  ����T  PUserManagementApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:UserManagementApplication.UserInterface'UserManagementApplication.UserInterface  5   	   <    6UserManagementApplication.UserInterface.ForgetPassword   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:UserManagementApplication.UserInterface     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  ForgotPassword��5	   	   $��581.218��6    $��357.417��61    � WindowStartupLocation$ CenterScreen=�5
   	   $��Segoe UI Emoji)�5   	   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ White��6   $ 1Q�6-   5      .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FF2281D1��6#   � 5      $ 	#FF34268A��6#   $ 1Q�65   � 5      $ 	#FF33288B��6#   $ 0.546Q�65   5      5      �� 5   
   $	��280��6   $	��341��6    $��Bottom=�6-   $��
35,0,42,34q�6H    �� RadiusY$ 10��6\    �� RadiusX$ 10��6i   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      	   
BlurRadius$	 15Q�6#   
   	Direction$
 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5!      � 5"   
   $��Bottom=�6   $��35,0,35,135q�6*   $	��240��6?   .+�5#      �� $��FORGOT PASSWORD��6   $��Center=�6.   $	��Top=�6K   $��5q�6c   
�������$��18(�6�   �� 5$      $��Center=�6   $��15,40,15,-48q�64   .+�5%      �� -   5         ��Name$ 	txt_email��5%      $
��0,10q�6-   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ EMAIL��6;    %  !MaterialDesignFloatingHintTextBox#��[  6b   $��Champagne & Limousines)�6�   $��18(�6�   G� 5&      -   5         G�Name$ txt_PasswordOld��5&      $
��0,10q�67   $ Old Password��6E    ) %MaterialDesignFloatingHintPasswordBox#��[ 6s   $��Champagne & Limousines)�6�   $��18(�6�   G� 5'      -   5        $ txt_PasswordNew��5'      $
��0,10q�67   $ New Password��6E   #��[ 6s   $��Champagne & Limousines)�6�   $��18(�6�   G� 5(      -   5        $ txt_passwordReType��5(      $
��0,10q�6:   $ Retype Password��6H   #��[ 6y   $��Champagne & Limousines)�6�   $��18(�6�   5)      5*      �� 5+   
   -   5         ��Name$ 	btn_Apply��5+      $	��150��6$   $��Center=�60   $��Bottom=�6M   $��105,0,102,18q�6h   $��APPLY��6~   6�   �� 5,   
   $>��8/UserManagementApplication;component/Assets/IconHelp.png��6   $	��106��6R   $	��Top=�6_   $��118,36,115,0q�6w   �� 5-   
   -   5         ��Name$ img_Back��5-      $
��Left=�6"   $��29��6=   $	��Top=�6I   $��29��6a   $>��8/UserManagementApplication;component/Assets/IconBack.png��6l   6�   5.      5/      