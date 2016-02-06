﻿module Ploeh.Numsense.CatalanExamples

open Xunit
open Swensen.Unquote

[<Theory>]
[<InlineData(                                             "zero",          0)>]
[<InlineData(                                            " zero",          0)>]
[<InlineData(                                            "zero ",          0)>]
[<InlineData(                                         "  zero  ",          0)>]
[<InlineData(                                             "Zero",          0)>]
[<InlineData(                                             "ZERO",          0)>]
[<InlineData(                                          " zERo\t",          0)>]
[<InlineData(                                               "un",          1)>]
[<InlineData(                                               "UN",          1)>]
[<InlineData(                                              "dos",          2)>]
[<InlineData(                                             " dos",          2)>]
[<InlineData(                                             "tres",          3)>]
[<InlineData(                                           "tres  ",          3)>]
[<InlineData(                                           "quatre",          4)>]
[<InlineData(                                        "  quatre ",          4)>]
[<InlineData(                                             "cinc",          5)>]
[<InlineData(                                             "CinC",          5)>]
[<InlineData(                                              "sis",          6)>]
[<InlineData(                                          "  SIS  ",          6)>]
[<InlineData(                                              "set",          7)>]
[<InlineData(                                          "    sEt",          7)>]
[<InlineData(                                             "vuit",          8)>]
[<InlineData(                                             "vUIT",          8)>]
[<InlineData(                                              "nou",          9)>]
[<InlineData(                                            "NoU  ",          9)>]
[<InlineData(                                              "deu",         10)>]
[<InlineData(                                             "onze",         11)>]
[<InlineData(                                            "dotze",         12)>]
[<InlineData(                                           "tretze",         13)>]
[<InlineData(                                          "catorze",         14)>]
[<InlineData(                                           "quinze",         15)>]
[<InlineData(                                            "setze",         16)>]
[<InlineData(                                           "disset",         17)>]
[<InlineData(                                           "divuit",         18)>]
[<InlineData(                                            "dinou",         19)>]
[<InlineData(                                             "vint",         20)>]
[<InlineData(                                        "vint-i-un",         21)>]
[<InlineData(                                       "vint-i-dos",         22)>]
[<InlineData(                                           "trenta",         30)>]
[<InlineData(                                    "trenta-quatre",         34)>]
[<InlineData(                                      "trenta-vuit",         38)>]
[<InlineData(                                         "quaranta",         40)>]
[<InlineData(                                      "quaranta-un",         41)>]
[<InlineData(                                  "quaranta-quatre",         44)>]
[<InlineData(                                        "cinquanta",         50)>]
[<InlineData(                                    "cinquanta-set",         57)>]
[<InlineData(                                         "seixanta",         60)>]
[<InlineData(                                    "seixanta-cinc",         65)>]
[<InlineData(                                          "setanta",         70)>]
[<InlineData(                                      "setanta-set",         77)>]
[<InlineData(                                      "setanta-nou",         79)>]
[<InlineData(                                         "vuitanta",         80)>]
[<InlineData(                                     "vuitanta-sis",         86)>]
[<InlineData(                                          "noranta",         90)>]
[<InlineData(                                     "noranta-tres",         93)>]
[<InlineData(                                             "cent",        100)>]
[<InlineData(                                          "cent un",        101)>]
[<InlineData(                                        "dos-cents",        200)>]
[<InlineData(                             "dos-cents trenta-set",        237)>]
[<InlineData(                          "tres-cents setanta-cinc",        375)>]
[<InlineData(                             "quatre-cents noranta",        490)>]
[<InlineData(                         "cinc-cents seixanta-tres",        563)>]
[<InlineData(                                 "sis-cents divuit",        618)>]
[<InlineData(                            "set-cents setanta-set",        777)>]
[<InlineData(                                  "vuit-cents cinc",        805)>]
[<InlineData(                                   "vuit-cents sis",        806)>]
[<InlineData(                                   "vuit-cents set",        807)>]
[<InlineData(                          "nou-cents cinquanta-nou",        959)>]
[<InlineData(                                              "mil",       1000)>]
[<InlineData(                                           "mil un",       1001)>]
[<InlineData(                                          "mil dos",       1002)>]
[<InlineData(                              "mil seixanta-quatre",       1064)>]
[<InlineData(                                          "dos mil",       2000)>]
[<InlineData(                     "vuit mil set-cents vint-i-un",       8721)>]
[<InlineData(                         "nou mil cent vint-i-tres",       9123)>]
[<InlineData(                                          "deu mil",      10000)>]
[<InlineData(                                  "deu mil cent un",      10101)>]
[<InlineData(                                 "deu mil cent dos",      10102)>]
[<InlineData(       "vint-i-tres mil cinc-cents seixanta-quatre",      23564)>]
[<InlineData(                                 "vuitanta mil deu",      80010)>]
[<InlineData(                                         "cent mil",     100000)>]
[<InlineData(                                      "cent mil un",     100001)>]
[<InlineData(     "tres-cents dinou mil tres-cents quaranta-nou",     319349)>]
[<InlineData(                                         "un milió",    1000000)>]
[<InlineData(                                      "un milió un",    1000001)>]
[<InlineData(                                  "dos milions deu",    2000010)>]
[<InlineData(                         "  sis milions trenta mil",    6030000)>]
[<InlineData(  "nou milions dos-cents un mil sis-cents vuitanta",    9201680)>]
[<InlineData(                                      "deu milions",   10000000)>]
[<InlineData(                                  "deu milions nou",   10000009)>]
[<InlineData(                                "vint-i-un milions",   21000000)>]
[<InlineData("quaranta-set milions sis-cents seixanta-un mil seixanta", 47661060)>]
[<InlineData(                                     "cent milions",  100000000)>]
[<InlineData(                           "dos-cents cinc milions",  205000000)>]
[<InlineData(                           "tres-cents set milions",  307000000)>]
[<InlineData("quatre-cents seixanta-un milions seixanta mil sis-cents", 461060600)>]
[<InlineData(                                      "mil milions", 1000000000)>]
[<InlineData(                                  "dos mil milions", 2000000000)>]
[<InlineData("dos mil quaranta-nou milions sis-cents cinquanta mil", 2049650000)>]
[<InlineData(
    "dos mil cent quaranta-set milions quatre-cents vuitanta-tres mil sis-cents quaranta-set",
    System.Int32.MaxValue)>]
let ``tryParseCatalan returns correct result`` (catalan, expected) =
    let actual = Numeral.tryParseCatalan catalan
    Some expected =! actual

[<Theory>]
[<InlineData(         0, "zero")>]
[<InlineData(         1, "un")>]
[<InlineData(         2, "dos")>]
[<InlineData(         3, "tres")>]
[<InlineData(         4, "quatre")>]
[<InlineData(         5, "cinc")>]
[<InlineData(         6, "sis")>]
[<InlineData(         7, "set")>]
[<InlineData(         8, "vuit")>]
[<InlineData(         9, "nou")>]
[<InlineData(        10, "deu")>]
[<InlineData(        11, "onze")>]
[<InlineData(        12, "dotze")>]
[<InlineData(        13, "tretze")>]
[<InlineData(        14, "catorze")>]
[<InlineData(        15, "quinze")>]
[<InlineData(        16, "setze")>]
[<InlineData(        17, "disset")>]
[<InlineData(        18, "divuit")>]
[<InlineData(        19, "dinou")>]
[<InlineData(        20, "vint")>]
[<InlineData(        21, "vint-i-un")>]
[<InlineData(        30, "trenta")>]
[<InlineData(        34, "trenta-quatre")>]
[<InlineData(        40, "quaranta")>]
[<InlineData(        42, "quaranta-dos")>]
[<InlineData(        50, "cinquanta")>]
[<InlineData(        58, "cinquanta-vuit")>]
[<InlineData(        60, "seixanta")>]
[<InlineData(        65, "seixanta-cinc")>]
[<InlineData(        70, "setanta")>]
[<InlineData(        79, "setanta-nou")>]
[<InlineData(        80, "vuitanta")>]
[<InlineData(        86, "vuitanta-sis")>]
[<InlineData(        90, "noranta")>]
[<InlineData(        93, "noranta-tres")>]
[<InlineData(       100, "cent")>]
[<InlineData(       101, "cent un")>]
[<InlineData(       110, "cent deu")>]
[<InlineData(       114, "cent catorze")>]
[<InlineData(       135, "cent trenta-cinc")>]
[<InlineData(       200, "dos-cents")>]
[<InlineData(       282, "dos-cents vuitanta-dos")>]
[<InlineData(       331, "tres-cents trenta-un")>]
[<InlineData(       407, "quatre-cents set")>]
[<InlineData(       520, "cinc-cents vint")>]
[<InlineData(       666, "sis-cents seixanta-sis")>]
[<InlineData(       798, "set-cents noranta-vuit")>]
[<InlineData(       857, "vuit-cents cinquanta-set")>]
[<InlineData(       999, "nou-cents noranta-nou")>]
[<InlineData(      1000, "mil")>]
[<InlineData(      1001, "mil un")>]
[<InlineData(      1010, "mil deu")>]
[<InlineData(      1066, "mil seixanta-sis")>]
[<InlineData(      1337, "mil tres-cents trenta-set")>]
[<InlineData(      1984, "mil nou-cents vuitanta-quatre")>]
[<InlineData(      2015, "dos mil quinze")>]
[<InlineData(      3000, "tres mil")>]
[<InlineData(      3297, "tres mil dos-cents noranta-set")>]
[<InlineData(      4080, "quatre mil vuitanta")>]
[<InlineData(      5011, "cinc mil onze")>]
[<InlineData(      6025, "sis mil vint-i-cinc")>]
[<InlineData(      7441, "set mil quatre-cents quaranta-un")>]
[<InlineData(      8513, "vuit mil cinc-cents tretze")>]
[<InlineData(      9000, "nou mil")>]
[<InlineData(     10000, "deu mil")>]
[<InlineData(     12001, "dotze mil un")>]
[<InlineData(     23456, "vint-i-tres mil quatre-cents cinquanta-sis")>]
[<InlineData(     32109, "trenta-dos mil cent nou")>]
[<InlineData(     40404, "quaranta mil quatre-cents quatre")>]
[<InlineData(     56789, "cinquanta-sis mil set-cents vuitanta-nou")>]
[<InlineData(     60015, "seixanta mil quinze")>]
[<InlineData(     71003, "setanta-un mil tres")>]
[<InlineData(     80522, "vuitanta mil cinc-cents vint-i-dos")>]
[<InlineData(     98765, "noranta-vuit mil set-cents seixanta-cinc")>]
[<InlineData(    100000, "cent mil")>]
[<InlineData(    100001, "cent mil un")>]
[<InlineData(    100010, "cent mil deu")>]
[<InlineData(    101010, "cent un mil deu")>]
[<InlineData(    200000, "dos-cents mil")>]
[<InlineData(    321000, "tres-cents vint-i-un mil")>]
[<InlineData(    411416, "quatre-cents onze mil quatre-cents setze")>]
[<InlineData(    530121, "cinc-cents trenta mil cent vint-i-un")>]
[<InlineData(    600000, "sis-cents mil")>]
[<InlineData(    788000, "set-cents vuitanta-vuit mil")>]
[<InlineData(    876540, "vuit-cents setanta-sis mil cinc-cents quaranta")>]
[<InlineData(    908077, "nou-cents vuit mil setanta-set")>]
[<InlineData(   1000000, "un milió")>]
[<InlineData(   2000002, "dos milions dos")>]
[<InlineData(   3040506, "tres milions quaranta mil cinc-cents sis")>]
[<InlineData(   4321000, "quatre milions tres-cents vint-i-un mil")>]
[<InlineData(   5004621, "cinc milions quatre mil sis-cents vint-i-un")>]
[<InlineData(   6982001, "sis milions nou-cents vuitanta-dos mil un")>]
[<InlineData(   7000000, "set milions")>]
[<InlineData(   8000220, "vuit milions dos-cents vint")>]
[<InlineData(   9099000, "nou milions noranta-nou mil")>]
[<InlineData(  10000000, "deu milions")>]
[<InlineData(  24000000, "vint-i-quatre milions")>]
[<InlineData(  39020011, "trenta-nou milions vint mil onze")>]
[<InlineData(  40606100, "quaranta milions sis-cents sis mil cent")>]
[<InlineData(  53000000, "cinquanta-tres milions")>]
[<InlineData(  64000098, "seixanta-quatre milions noranta-vuit")>]
[<InlineData(  70003190, "setanta milions tres mil cent noranta")>]
[<InlineData(  80000000, "vuitanta milions")>]
[<InlineData(  99000099, "noranta-nou milions noranta-nou")>]
[<InlineData( 100000000, "cent milions")>]
[<InlineData( 209000000, "dos-cents nou milions")>]
[<InlineData( 398000000, "tres-cents noranta-vuit milions")>]
[<InlineData( 439011000, "quatre-cents trenta-nou milions onze mil")>]
[<InlineData( 560400000, "cinc-cents seixanta milions quatre-cents mil")>]
[<InlineData( 600010900, "sis-cents milions deu mil nou-cents")>]
[<InlineData( 700000000, "set-cents milions")>]
[<InlineData( 800116000, "vuit-cents milions cent setze mil")>]
[<InlineData( 900800007, "nou-cents milions vuit-cents mil set")>]
[<InlineData(1000000000, "mil milions")>]
[<InlineData(2121000000, "dos mil cent vint-i-un milions")>]
[<InlineData(
    System.Int32.MaxValue,
    "dos mil cent quaranta-set milions quatre-cents vuitanta-tres mil sis-cents quaranta-set")>]
let ``toCatalan returns correct result`` (i, expected) =
    let actual = Numeral.toCatalan i
    expected =! actual