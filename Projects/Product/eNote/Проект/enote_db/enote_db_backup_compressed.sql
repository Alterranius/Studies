PGDMP     $                    {            enote_db    10.14    15.2 ;    $           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            %           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            &           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            '           1262    17236    enote_db    DATABASE     |   CREATE DATABASE enote_db WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE enote_db;
                postgres    false            �          0    17260    account 
   TABLE DATA                 public          postgres    false    203   �(       �          0    17268    account_data 
   TABLE DATA                 public          postgres    false    204   _-       �          0    17362    depart 
   TABLE DATA                 public          postgres    false    212   �1                 0    17398 	   indicator 
   TABLE DATA                 public          postgres    false    218   )3       	          0    17508    indicator_depart 
   TABLE DATA                 public          postgres    false    226   C3                 0    17576    indicator_metric 
   TABLE DATA                 public          postgres    false    234   ]3                 0    17405    indicator_pool 
   TABLE DATA                 public          postgres    false    220   w3                 0    17423    indicator_project 
   TABLE DATA                 public          postgres    false    222   �3                 0    17491    indicator_team 
   TABLE DATA                 public          postgres    false    224   �3       �          0    17341    methodology 
   TABLE DATA                 public          postgres    false    208   �3       �          0    17391    metric 
   TABLE DATA                 public          postgres    false    216   �4                 0    17525    metric_depart 
   TABLE DATA                 public          postgres    false    228   �4                 0    17542    metric_project 
   TABLE DATA                 public          postgres    false    230   �4                 0    17559    metric_team 
   TABLE DATA                 public          postgres    false    232   5       !          0    17724 
   permission 
   TABLE DATA                 public          postgres    false    250   ,5                 0    17600    plan 
   TABLE DATA                 public          postgres    false    238   F5                 0    17627    plan_content 
   TABLE DATA                 public          postgres    false    240   �6                 0    17593 	   plan_type 
   TABLE DATA                 public          postgres    false    236   
:       �          0    17350    project 
   TABLE DATA                 public          postgres    false    210   �:                 0    17717    resource 
   TABLE DATA                 public          postgres    false    248   �<                 0    17639    role 
   TABLE DATA                 public          postgres    false    242   �<                 0    17664    role_account 
   TABLE DATA                 public          postgres    false    244   )?       �          0    17280    task 
   TABLE DATA                 public          postgres    false    206   �A       �          0    17239    task_category 
   TABLE DATA                 public          postgres    false    197   jI       �          0    17253    task_status 
   TABLE DATA                 public          postgres    false    201   +J       �          0    17246 	   task_type 
   TABLE DATA                 public          postgres    false    199   �J       �          0    17374    team 
   TABLE DATA                 public          postgres    false    214   �K                 0    17700    zone 
   TABLE DATA                 public          postgres    false    246   FM       )           0    0    account_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.account_id_seq', 57, true);
          public          postgres    false    202            *           0    0    depart_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.depart_id_seq', 8, true);
          public          postgres    false    211            +           0    0    indicator_depart_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.indicator_depart_id_seq', 1, false);
          public          postgres    false    225            ,           0    0    indicator_id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.indicator_id_seq', 1, false);
          public          postgres    false    217            -           0    0    indicator_metric_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.indicator_metric_id_seq', 1, false);
          public          postgres    false    233            .           0    0    indicator_pool_id_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.indicator_pool_id_seq', 1, false);
          public          postgres    false    219            /           0    0    indicator_project_id_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.indicator_project_id_seq', 1, false);
          public          postgres    false    221            0           0    0    indicator_team_id_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.indicator_team_id_seq', 1, false);
          public          postgres    false    223            1           0    0    methodology_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.methodology_id_seq', 2, true);
          public          postgres    false    207            2           0    0    metric_depart_id_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.metric_depart_id_seq', 1, false);
          public          postgres    false    227            3           0    0    metric_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.metric_id_seq', 1, false);
          public          postgres    false    215            4           0    0    metric_project_id_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.metric_project_id_seq', 1, false);
          public          postgres    false    229            5           0    0    metric_team_id_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.metric_team_id_seq', 1, false);
          public          postgres    false    231            6           0    0    permission_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.permission_id_seq', 1, false);
          public          postgres    false    249            7           0    0    plan_content_id_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public.plan_content_id_seq', 25, true);
          public          postgres    false    239            8           0    0    plan_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.plan_id_seq', 13, true);
          public          postgres    false    237            9           0    0    plan_type_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.plan_type_id_seq', 2, true);
          public          postgres    false    235            :           0    0    project_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.project_id_seq', 9, true);
          public          postgres    false    209            ;           0    0    resource_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.resource_id_seq', 1, false);
          public          postgres    false    247            <           0    0    role_account_id_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.role_account_id_seq', 254, true);
          public          postgres    false    243            =           0    0    role_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.role_id_seq', 92, true);
          public          postgres    false    241            >           0    0    task_category_id_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public.task_category_id_seq', 5, true);
          public          postgres    false    196            ?           0    0    task_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.task_id_seq', 38, true);
          public          postgres    false    205            @           0    0    task_status_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.task_status_id_seq', 5, true);
          public          postgres    false    200            A           0    0    task_type_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.task_type_id_seq', 5, true);
          public          postgres    false    198            B           0    0    team_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.team_id_seq', 10, true);
          public          postgres    false    213            C           0    0    zone_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.zone_id_seq', 1, false);
          public          postgres    false    245            �   X  x��X�n�F��+f�`R&%]�hj\'�����&E��T4��Σ@ܴnS�hѦE@��Z����?�w��p�l�2=s���sϜ���֭{�Yu���h���S����1���tV���:\(ѽيTa��{nZ��M'��֡G�u<�{�W:k�Q��^�3��b��n��u�A�wc��y>��2������h�x�F~�:q�&{���}k�ݰm�i��G|_���^�D����_�l�@�\tĥ�!��R��|�3ї���Y�`Aہ<��:��g(���0f9���x�G��4����Fa�2��c���S��ƀ��>���'�j�<f������s�S��#_¸��l�8�9����L�T����,O�g�c�{��������Ղ�f�_E0l����Ts����ǭ�������U؃#��
<�=���rz�.�W��_�Y���G��='#,5k�M�)��|��Z4��+��jŬX�+�x+��Vۼ��Ȁ��b��b�g�Ų|�d�S$��.�Op��ׄ�.�1�!�1�g��6g�xN�S��|�PN�~�?�zG��|A5���z�B�_���=>�ذz�����P�g�({"@F)v�S:TF�������0��j�)
�xň����	x��������S����0��Ik_Ŏ��9l4�PK3dMہ��9�� �X\q�!E���z3��\��W� �P��v�'4�^����Z$�fH�D�*�1�A2MdQ6.�m�7j�Q<��JU|�_]u簄$�C�=@V�4��\PY�rFyV�A���1	8�N0:Tݮ6g�~-�)R�|��,ئeZ�YRW9�����Cģ4{�p��������x@�R9�ē�λ�W%`�Bٮ�_k�Wc��S��T��
��h�MP �,�koyQ��#nt�>{3�d��v��'�È�:��!1X���V�X��2�R���T��~�Q	�tlv)���-���/��FٴJ�+�ta�n��T�@������t�!̒��c<U(��(:�_:���[�B4�W~�����޲�t����oӏ�	S�Fb¾���ִ�%      �   L  x���K��J �}~��TMR5�B?h�n��Q@|mR���m@����L���ܝ������9�N��9k�ә�8�N�o �l���}wY�_^#�}l��,�G��E«k�}r�.x1��Ɔ{,���,�ژ��v�j|���0g����C|��(|^iiR�jx��'g�#�����>�8Hw��Q������<��QFH�D�u���o��~�
=	�	��Z�D����I���T%���?�H�D��IT����Z4�̑������]���g��PZ���3z���_�y�k���!��-� 𽬴*��E����vd��n4�Zь�ݲ\�=1���;�p��`��'�k�"�L��ۺB$"�0�%�_���"�E@Ż-�\���y��7V�x�~q���ur��������y=�*��N�;st�;˱�w£���[Q:���~���]��-�(�{y������8���(�N�3^O��ـ�6�� *���D�O��t裁.�ŏ�`��?3���H��Nb"T%�,.���5C�8��>ì���\�}����G�@v,&�3����dݼ�^��7�_�Z�D(��+^���]�r��ہ+ma�i�=O�:�v�,l��"٭�7-� 43 �7.y�:u���Z` �{5+k�ǳ=�᪹E'���fqL�	��/�4�؝dӶ�UO~���1մ�kGA|������C�������j��[��%KafLP��4[*i腲��3�I�=��d1]�e3L.�4#��R$�q�:�GZ,� �,�K���*��C�Kܼ�J�a_#�0Ƕo{��yg�V~��~���R�ԁ"��3�]��Xa	~mUO�jqQ �{�fR2��d�W6�Y�M�>��Y��˙��8
A�_�a�O�K��آ}�2dY��Li�Q�a���s5�~���NV�*a�Y~;����.V�M�\���Xʆ�R/WIg`�/��?ҥ�ZK�X�n���}�d�J������?���Dw�R��J=��@ǘr-1u��������$w�hS��N�L?�i�t0�G(�����)x�Q
D�릭���߬J�a[PT���ӧ�P�5      �   ^  x����N�@��}����*$�HʁD1�jj[������D�$r�>B�T����9mA���Kg���7�o��J�tT�r�vV�.�-ô4ہ�0hhW��y���rD���e7���ċKSwN������q�
��r�~�ɫ��ݓʛ����a�l�h�{F����y��s���>8���z��C�pȥ[� ��f{����	�m�����/���uj���<�n��;K�.��H\��Ll���!�+vc�����_��o�����,qv��E�v�� =��D$S��'��doˇc��
KP#n�c��.�y�cZ:�d��Eo�$��Q��)a��g
'I?���=         
   x���          	   
   x���             
   x���             
   x���             
   x���             
   x���          �   �   x���v
Q���W((M��L��M-��O���O�T��L�Q�K�M�Q(�H-�,�QHI-N.�,(����Ts�	uV�0�QPwL��IU2.̹����;.�\�z��b�Bfօ�6 ���� ����~�P녭�\ؠ�i��IGmt���X=�bÅ�^l��/v+ d���(���`�4 ��������`r#P�	�l�[.�)����
�4fPɾ�@��� �?��      �   
   x���             
   x���             
   x���             
   x���          !   
   x���             p  x����J�@��}���� �ZT<y(R(��Ub�C���ԃ�6ETZEP��B� �kK�+̼����>���L6��7�L�Z/�P�6N����8��c��u�&�V�6�r�&�o<�\�y��K�՗�m{VO�}��r����J�T�l��ih��j�R1�`��5w�)�?d��\C��!���{��F4����%^1�!����iD>M �1�w�pAc>TH��P1Mi�1#��j�7�����J.$a��)S��
�ߎEg�k��>���y#�)k�d�P��Eјn��z �C���~AO�pJ��Y"="5T8�*f���	U�/��~��8=�]F*yNK����=� G�+��VRת7��(؀�p�]k��/n&��w�#         4  x��VKKQ��+.nFaZ����+�b�Z�%ͤe@��D)�b�%R[���}a���1N�½���9sg��[���d��3���q�diye�ɪXZ^},*[�׽���z���P.U�����\[��E[�E���U�^�d���a��J���y����N���GOW�Df���mẽ�^[�M>[2�v��P>���Z�S�t�YF���Hwv|�O���3����z������6��f� �%?�P�d[��P2�g��.�y��:q�H��+��Z^�o�����HPv��z�U��nS����Y�r����9���n���';V�6s�td@W�H��j`��^c'�@� B�� ,���j�_�|
���끄 �ɘE=âS������s�n��&Bj��\�	����`P�A�y��7k���Gx!Ej�U��ۂ���Ж�]�*�����4�'u~���Ae<�M�KK�xZJ�?A4�&9R��j?b;is�5��!V��l<�����m|�����L�:�4�9�N<;«ǀ�S�J�QҬ�hԤ返���b����!w���n*ڕ!vs�Yp��@b�͍��P\b��'���k�4�����ރ�[�w��,F�YH��}J�(�ˊ\����t{�̺%?�ĩ����"'2��B8|R�:�1O�skk�"�����D����6�26v�4�N��C5x*��5��)�4d��
us-���&ϲNj�;k���m=���Y�����&W�}wL�#z�G6�T�|�X�0�p��'&�����<�N�Xy
CR���Ǥ�RGF���gxV�06�kZę         �   x���v
Q���W((M��L�+�I̋/�,HU��L�Q�K�M�QHI-N.�,(����Ts�	uV�0�QP�����;.6^�wa�:�?�ہ�M�/�T J �5��<)��l����.��l�| k����) ݱ�bӅ6�d/����� �n�      �     x��T�n�@��{s"��:6lO=䀄HH�ȵ������I�^���*��F=G"iH\(�f���k�#����̾y���R�o�4H���"�����:��e��d-�U�v�t����Jz���V�ƍè�?p�V�Fľ����� ��$��C/�L�G~Ԋ�^7���8�n�N�=��n��U��z�"��� 2u�u������t��V�b8̲u4�V֟*�$��V���B��N�n�KqI��zM�Y6��f��+'��^�+��oa
�0�}`��c������|�s\��B��l��p��c	x"����Yz����,�`Ő���3���`� �P���`��W��e�똟*�#AFnT�m�L�5j9+7�R�Y��N`���
!��ta�?��x�d�^�~ďP�Pz{�����1�Q�h8��
N�?�YZ����| ���.+�����7�br7x��-�F�q�Dיn0Z����㔳'�.��t���h^���u,1˜�����d�         
   x���             1  x����JA�O1���%Vwg��IЃ`
�]�t���١N�9��D�(��fߨ� V�Nߙo����|���|��n�'��^G�ώ'��n�N�=9b6�&�%��l<_�ә#��$�1�ғd�8Zk����(���{�,�Î8������vQ��*�k��t�L���Z���앚��V��Swj��ԛ�W��V�z|�o�z��?�V������-_�R���q!R/f�So�z��5+=<�G}c-y[_��$Ћ�����?KmX�g�������j<���q#K$6`dM Xȅ����%6`dMXD��..`dI0��
X̅x���%>6`dMXQ�هĸ�q%������"7�!�S$Y>E�5��̷���`Iln��	\#��!3#H��F��z�"$��`d	�#kp=Xڇ {0�܃�5����CB`F��{0�׃m����`d	�#k$8`�	��IB�i�Ek����V�$2R��4p�B��M�M�n�#���$F�|����,�ɧI�4�,M�n�+.K��y#]�N���V�         Y  x���=o1�ݿB[�,H�>(u��@�M�5p����_�
�^:T�v��>H������~{0����������ξ��������σ�~y^��<������~{�??n7���/�o�͵ϋq�	��+p�k��O�zg	c�pu�i���nIG8�?pZ;4.W�*�u�b�#`1&�X�*rYL�38^�1fp~1Td`9*�R�RS����b�>Y(p{-�\�h���ԚW�p#T�,q��ni-d:,++d>�ń�K��:
�H-�l�\J �8���[5Mw�]Ѐ�����+��=��ty2���^	1������r�k��}��L2���x���Oc�Xl�����u
p�k��iNw���0*-1 OuVi^������}>���
dsr8�
#�G\��M�%�aD��z�sb���91_f5��6�ľ鲗sQ�gp���d�τ*�K9n����l�̢�]�UI�
2�9�Ȭf����65��H"�:��T�%��/��I�˱��3g,�[��G��]��ܢ��,��t�\�w��r�9[A�W�����X�ˏ
_�Cc�B1_m��A^�~�XU�      �   �  x��ZKo�V��+���u�~LWEE	Q�Iآ!���G��d�<��DB*��)T�O�L�������s=O�!	;�ﹾ��s�w^�~s��O���?kw�,��F�^pqey.x�xМ�V�q\n���W��+�炵������#כ�vs�v�MS�7���V��o�0~wu��mZ��n�7Z|�~��������öl6��Rp���W烋���l/��f�|;����$�̾�;�V�	 {�k4�4��g��N���)�Y?;�NL��e?��u��V���1xʲ��콛=!���<I	�/��ЁPu)�Z�6� ��x������\&���p�Ы�x+  d/;"��Nv�&��>싷.c�S�mb�0���S/�"�
�Ja�֕
��U!����c*�-	ٷd���dG���Ubg��A��}���������B��Ic�B"��N�������C�������������0w����I��}��`�g}�1]̧�S+ς�c �*Com]�0�um����������d����~&��w���ߒ��b��A��!#��h��ideݦu�B��:&{72��zDI]�ajt�fN. ��2!�����O�82�s�%ڑ禝�s<����.U(b��QƬ�iQ�[�=�#���L1L��|i�'��9
�s6�!�K'���ʊ�e�@F^�R�.5�m�PI��(#�(���PTZEI¢��3�\��b"Ќ"�l4"��	R�uZ���D:�uhlS]4G��`E=volX_���ƞp�}\���_� �>;Ⱥ� �
��6��l��V@�;~�E�Η���F�~���ր@J��>U$aRf~��i�r�V�1�u�7X��d�|�?���NR�J�LѠS�1"|L�Y��]k�V�k�t��/Ä�L2	U�"��_��#�du1�À��ه�V����7��4Z�� +RF��dL^(�|�KJZRq\��ER�rec�^��O��[~���MC��L(��zE�֑H�A�����ڭ{��O�C~RRƅdWj3��)�:�/�Bc	X5�Ī���_��Ξ����s���Ζ�Y_��R��*�H��r{\iN��U(��7�xp�EW�f���1^�p��N�QN?1�i��ft'���M�o��Z�SᏛ�D0U7nBz_[h���F~����$U��t�T�I�(
S��8��'����X怭Q9��>g�E��<Ku��3V���\�A$�F��H����6�-��VW�~�-�c����6���C�\K��1��^M/0:l��A�P�EF �(�5D��l$9&���G3A?d�:�U�S�qELZ��T s"ʸd̂�� �"'��J�"���.���8��e^F�@pmRщ1�%�eU�cS]U�+�ͻc�T�-��\X�+�?nz����[��)�JDadF��xKU.�� ���Qdu0��z̗}�`E�6��vElc��J��{Fi�K�E�7��*�J�B��	E��縜��̟�a-�K�H1-��������;���䞌)�hZךh4.��X$�0�&�]W)\��d�9ޏ;��1��K�X$���_&~R�~�9�����6����	;��~�4�~�:���b �q����0��y�(����L1e�*�H�"-Ø}�~b+�	{ї��y�u����g�c����B��J�t�#oW��rH��T��:�5vӨXj+����w���h>(l�K�4C�������o衼2���_��V�O	�?��Se)�qW�9��i=�A����f鷴�i����rL�K�r8�!�Ĕv ��%��԰7W�rETC�~���S1I��$�$�@&�x�:��>³�԰Z�7UE�x�I�ߍ]8��F��z��@�a�L��dsd�%�c�Gq�6�C�V�(�I����������W2�+jՅ�#[0      �   �   x���v
Q���W((M��L�+I,ΎON,IM�/�T��L�Q�K�M�Ts�	uV�0�QP�0�¾[.l����@��.콰��VuMk.O2L5�:h�ދm@s�_lҽ��b��&r4� ��@n���¾�Mv]�@�y& �]�z�h�<m
q���.�\��f* �E��      �   �   x���v
Q���W((M��L�+I,Ύ/.I,)-V��L�Q�K�M�Ts�	uV�0�QP�0I�bÅ6^�w���VuMk.O�2t�����.쾰��V �@�Y� ��ݴ��&��vSb�	Ȭ��*����D^l��@S���.l������[/6)\�u�V �����\\ '~��      �   �   x���v
Q���W((M��L�+I,Ύ/�,HU��L�Q�K�M�Ts�	uV�0�QP�0�¾[�5��<I�m�m|a�= .l���b9��\���֋��t/���b#9��Z Կ�b��>rL0�0�b����/6�L�� z�{M      �   �  x����N�P��<����W$� 1��5HY4�Bj�-5(ĕ��`�P�h�>��9紨D�Mæ���?g���$���A��>��'y5�n�2�J �L! %w��Ւ�� ���R�ⴔэcU��Ql�0�_0 ޘ�-j��ug n�~�;������� �E�G�h��ըJ-��ϰ�S���Ц΋�Ӎ}-�j9>	��@wt�#.<��L����C@���
v�w����a�yÂ�E�R�?f�Q�.X:d�UqFSGrpD�5�~�7IԐ�m���ww����Ԥp��W�q7u��O��o���!�r��a�l�%{�ҵ9�ر����I�NBg���RԨ˨�� ��5���7۟����³<7x!}%6on|���ES2>
w�����;A{��T��̯��{M�         
   x���         