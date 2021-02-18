using System.Diagnostics;
using BenchmarkDotNet.Attributes;

namespace MyBenchmarks.Benchmarks
{
    [MemoryDiagnoser]
    public class BubbleSort : IBenchmark
    {
        [Benchmark]
        public void DoBenchmark(int count = 1)
        {
            Debug.WriteLine("Starting Bubblesort");

            // Sequence from 1 to 1000
            // Generated from https://www.random.org/sequences/
            
            var input = new int[]
            {
                717, 489, 853, 474, 251, 14, 205, 539, 432, 925, 613, 190, 575, 790, 732, 667, 468, 57, 387, 748, 786,
                501, 213, 950, 48, 348, 518, 603, 410, 655, 828, 214, 840, 709, 859, 718, 747, 982, 659, 544, 542, 34,
                883, 249, 447, 293, 114, 59, 891, 297, 815, 53, 308, 240, 29, 919, 527, 958, 254, 42, 593, 551, 847,
                438, 507, 763, 247, 193, 105, 347, 208, 448, 364, 943, 187, 264, 333, 6, 170, 687, 458, 870, 920, 719,
                342, 374, 330, 118, 138, 837, 533, 954, 198, 813, 896, 993, 412, 107, 392, 288, 352, 71, 932, 216, 291,
                383, 455, 145, 153, 721, 116, 947, 767, 882, 460, 644, 796, 368, 890, 933, 924, 390, 515, 443, 119, 666,
                180, 234, 557, 212, 490, 994, 745, 827, 903, 598, 930, 597, 558, 457, 424, 900, 139, 273, 985, 901, 856,
                793, 203, 902, 649, 344, 277, 979, 9, 783, 866, 637, 761, 730, 343, 892, 467, 241, 313, 690, 365, 769,
                914, 872, 183, 182, 508, 255, 23, 618, 54, 270, 104, 784, 713, 519, 555, 727, 123, 977, 120, 808, 529,
                988, 780, 1, 564, 305, 741, 670, 960, 538, 523, 319, 130, 85, 531, 619, 77, 52, 237, 522, 370, 192, 462,
                940, 327, 782, 223, 777, 385, 989, 84, 738, 991, 516, 98, 256, 640, 36, 913, 80, 928, 453, 267, 797,
                752, 161, 749, 35, 514, 607, 823, 11, 304, 396, 454, 97, 136, 227, 253, 517, 737, 75, 609, 582, 978,
                605, 465, 528, 495, 486, 584, 17, 224, 429, 716, 673, 99, 871, 151, 174, 829, 31, 591, 854, 19, 73, 746,
                260, 449, 627, 154, 714, 760, 710, 326, 407, 20, 502, 406, 639, 140, 354, 132, 10, 166, 936, 65, 929,
                175, 534, 302, 233, 441, 679, 450, 541, 628, 886, 696, 299, 401, 272, 996, 437, 479, 865, 669, 218, 583,
                697, 62, 841, 648, 322, 295, 63, 785, 127, 850, 941, 552, 852, 500, 76, 580, 286, 641, 156, 788, 185,
                543, 869, 910, 274, 567, 66, 222, 838, 855, 915, 290, 509, 228, 393, 810, 225, 816, 948, 849, 625, 677,
                476, 238, 350, 570, 403, 259, 521, 722, 25, 739, 826, 3, 371, 51, 799, 867, 921, 629, 961, 26, 41, 331,
                165, 493, 975, 806, 442, 311, 665, 220, 446, 472, 537, 33, 361, 635, 922, 340, 332, 863, 395, 661, 101,
                131, 21, 484, 653, 596, 963, 668, 309, 725, 159, 926, 391, 334, 239, 794, 359, 426, 360, 191, 261, 167,
                301, 602, 369, 349, 970, 78, 143, 418, 108, 773, 556, 209, 92, 990, 946, 862, 821, 204, 427, 200, 90,
                664, 617, 801, 554, 197, 693, 927, 831, 997, 701, 842, 680, 824, 787, 296, 678, 654, 221, 604, 168, 411,
                122, 353, 576, 672, 483, 384, 217, 219, 553, 647, 949, 60, 275, 873, 284, 397, 141, 610, 969, 720, 339,
                292, 366, 897, 417, 336, 751, 148, 420, 439, 451, 142, 16, 803, 294, 4, 843, 643, 282, 699, 22, 789, 89,
                503, 525, 278, 634, 318, 231, 37, 858, 526, 196, 744, 658, 984, 992, 822, 266, 550, 651, 496, 230, 594,
                452, 287, 475, 742, 252, 61, 750, 536, 736, 566, 5, 974, 103, 754, 820, 817, 235, 662, 444, 40, 652,
                524, 186, 492, 68, 905, 431, 423, 351, 595, 13, 685, 162, 202, 904, 676, 703, 487, 848, 320, 966, 49,
                341, 911, 546, 405, 888, 893, 242, 887, 590, 402, 916, 413, 129, 199, 832, 755, 382, 918, 93, 833, 759,
                147, 809, 181, 245, 173, 24, 133, 908, 708, 895, 592, 825, 620, 345, 691, 684, 386, 733, 497, 645, 285,
                781, 656, 935, 367, 967, 762, 835, 682, 614, 939, 694, 535, 530, 488, 880, 388, 884, 440, 774, 56, 889,
                734, 632, 27, 378, 674, 32, 879, 663, 248, 616, 945, 623, 675, 100, 965, 601, 445, 731, 263, 874, 67,
                435, 50, 38, 469, 121, 215, 189
            };

            for (int i = 0; i < count; i++)
            {
                Debug.WriteLine($"Starting iteration : {i}");
                var output = Sort(input);
            }
        }

        private int[] Sort(int[] input)
        {
            if (input == null)
            {
                return null;
            }

            for (int write = 0; write < input.Length; write++)
            {
                for (int sort = 0; sort < input.Length - 1; sort++)
                {
                    if (input[sort] > input[sort + 1])
                    {
                        var temp = input[sort + 1];
                        input[sort + 1] = input[sort];
                        input[sort] = temp;
                    }
                }
            }

            return input;
        }


    }
}