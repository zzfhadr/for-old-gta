�WODE  � 
    � J V � �1M ���� 
 q ,���� J V � �2M ���� 
 r ,���� J V � �3M g��� 
 p ,���� J V � �4M ;��� 
 �  ,���� J V � �5M ��� 
 �  ,���� J V � �6M ���� 
 �  ,���� J V � �7M ���� 
 �  ,���� J V � �8M ���� 
 �  ,���� J V � �9M _��� 
 �  ,���� J V � �0M 3��� 
 �  ,��� ����  G
 p  �       @@        �  H
 M ����� 
      u  i   d�  � ����VAR '   ARENA_DOOR_1    ARENA_DOOR_2    CAR_SHOWROOM_ASSET �  CURRENT_TIME_IN_MS �  CUT_SCENE_TIME |   DEFAULT_WAIT_TIME    FILM_STUDIO_ASSET �  FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_BACK_GATE_OPEN   FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   ONMISSION 9  PASSED_ASS1_RUB_OUT �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_KENT1_DEATH_ROW �   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PASSED_TEX1_FOUR_IRON �   PLAYER_ACTOR    PLAYER_CHAR    PRINT_WORKS_ASSET �  FLAG   SRC �	   {$CLEO .cs}
 script_name 'WODE'
 var
 10@ : int =0  //130-236 180 and 181 is plane mode not availbe vehicle  6000֮���Ǽӳ����   
 end 
 :WODE_1
 wait 0
 if and
 044A:   player $PLAYER_CHAR on_foot
 player.Defined($PLAYER_CHAR)
 05EE:   32  //spacebar
 05EE:   49 //1 
 then
 10@=6001     //  �ܳ�  
 jump @WODE_SHUA
 end
 
  if and
 044A:   player $PLAYER_CHAR on_foot
 player.Defined($PLAYER_CHAR)
 05EE:   32  //spacebar
 05EE:   50 //2
 then
 10@=6002  //�����
 jump @WODE_SHUA
 end
 
  if and
 044A:   player $PLAYER_CHAR on_foot
 player.Defined($PLAYER_CHAR)
 05EE:   32  //spacebar
 05EE:   51 //3 
 then
 10@=6000   //���� 
 jump @WODE_SHUA
 end
  
  if and
 044A:   player $PLAYER_CHAR on_foot
 player.Defined($PLAYER_CHAR)
 05EE:   32  //spacebar
 05EE:   52 //4 
 then
 10@=141  //  infu... 
 jump @WODE_SHUA
 end
  
  if and
 044A:   player $PLAYER_CHAR on_foot
 player.Defined($PLAYER_CHAR)
 05EE:   32  //spacebar
 05EE:   53 //5
  
 then
 10@=217  // ����ֱ���� 
 jump @WODE_SHUA
 end
  
  if and
 044A:   player $PLAYER_CHAR on_foot
 player.Defined($PLAYER_CHAR)
 05EE:   32  //spacebar
 05EE:   54 //6 
 then
 10@=162   //̹�� 
 jump @WODE_SHUA
 end
  
  if and
 044A:   player $PLAYER_CHAR on_foot
 player.Defined($PLAYER_CHAR)
 05EE:   32  //spacebar
 05EE:   55 //7 
 then
 10@=227  //����ֱ���� 
 jump @WODE_SHUA
 end
  
  if and
 044A:   player $PLAYER_CHAR on_foot
 player.Defined($PLAYER_CHAR)
 05EE:   32  //spacebar
 05EE:   56 //8 
 then
 10@=191  //PCJ600
 jump @WODE_SHUA
 end
  
  if and
 044A:   player $PLAYER_CHAR on_foot  //139, 	stretch��ν�����س���A�㣬��֪���ǲ��� 
 player.Defined($PLAYER_CHAR)
 05EE:   32  //spacebar
 05EE:   57 //9 
 then
 10@=216  // ���������⳵ 
 jump @WODE_SHUA
 end
  
  if and
 044A:   player $PLAYER_CHAR on_foot
 player.Defined($PLAYER_CHAR)
 05EE:   32  //spacebar
 05EE:   48 //0 
 then
 10@=155   //������ 
 jump @WODE_SHUA
 end
 

 jump @WODE_1
 
 :WODE_SHUA
 wait 0
  0247: request_model   10@//#INFERNUS
 0170: 4@ = player $PLAYER_CHAR z_angle  
 04C4: create_coordinate 0@ 1@ 2@ from_actor $PLAYER_ACTOR offset 0.0 3.0 0.0 
 if 
 0248: 10@//#INFERNUS    
 jf @WODE_1  
 00A5: 3@ = create_car 10@ at 0@ 1@ 2@     //#INFERNUS
 0175: set_car 3@ z_angle_to 4@ 
 0369: put_player $PLAYER_CHAR in_car 3@
 wait 100
 Car.RemoveReferences(3@) 
 wait 1000
 jump @WODE_1
  
                          H  __SBFTR 