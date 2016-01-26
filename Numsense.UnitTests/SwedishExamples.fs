﻿module Ploeh.Numsense.SwedishExamples

open Xunit
open Swensen.Unquote

[<UseCulture("sv-SE")>]
[<Theory>]
[<InlineData(                                             "noll",          0)>]
[<InlineData(                                            " noll",          0)>]
[<InlineData(                                            "noll ",          0)>]
[<InlineData(                                         "  noll  ",          0)>]
[<InlineData(                                             "Noll",          0)>]
[<InlineData(                                             "NOLL",          0)>]
[<InlineData(                                           "nOll\t",          0)>]
[<InlineData(                                              "ett",          1)>]
[<InlineData(                                               "en",          1)>]
[<InlineData(                                              "ETT",          1)>]
[<InlineData(                                              "två",          2)>]
[<InlineData(                                             " två",          2)>]
[<InlineData(                                              "tre",          3)>]
[<InlineData(                                            "tre  ",          3)>]
[<InlineData(                                             "fyra",          4)>]
[<InlineData(                                          "  fyra ",          4)>]
[<InlineData(                                              "fem",          5)>]
[<InlineData(                                              "FeM",          5)>]
[<InlineData(                                              "sex",          6)>]
[<InlineData(                                          "  SEX  ",          6)>]
[<InlineData(                                              "sju",          7)>]
[<InlineData(                                          "    sJu",          7)>]
[<InlineData(                                             "åtta",          8)>]
[<InlineData(                                             "åTTA",          8)>]
[<InlineData(                                              "nio",          9)>]
[<InlineData(                                            "Nio  ",          9)>]
[<InlineData(                                              "tio",         10)>]
[<InlineData(                                             "elva",         11)>]
[<InlineData(                                             "tolv",         12)>]
[<InlineData(                                          "tretton",         13)>]
[<InlineData(                                          "fjorton",         14)>]
[<InlineData(                                           "femton",         15)>]
[<InlineData(                                           "sexton",         16)>]
[<InlineData(                                          "sjutton",         17)>]
[<InlineData(                                            "arton",         18)>]
[<InlineData(                                           "nitton",         19)>]
[<InlineData(                                            "tjugo",         20)>]
[<InlineData(                                         "tjugoett",         21)>]
[<InlineData(                                          "tjugoen",         21)>]
[<InlineData(                                          "trettio",         30)>]
[<InlineData(                                      "trettiofyra",         34)>]
[<InlineData(                                           "fyrtio",         40)>]
[<InlineData(                                       "fyrtiofyra",         44)>]
[<InlineData(                                           "femtio",         50)>]
[<InlineData(                                        "femtiosju",         57)>]
[<InlineData(                                           "sextio",         60)>]
[<InlineData(                                        "sextiofem",         65)>]
[<InlineData(                                          "sjuttio",         70)>]
[<InlineData(                                       "sjuttionio",         79)>]
[<InlineData(                                            "åttio",         80)>]
[<InlineData(                                         "åttiosex",         86)>]
[<InlineData(                                           "nittio",         90)>]
[<InlineData(                                        "nittiotre",         93)>]
[<InlineData(                                           "hundra",        100)>]
[<InlineData(                                        "etthundra",        100)>]
[<InlineData(                                        "hundraett",        101)>]
[<InlineData(                                         "hundraen",        101)>]
[<InlineData(                                     "hundraochett",        101)>]
[<InlineData(                                      "hundraochen",        101)>]
[<InlineData(                                   "hundra-och-ett",        101)>]
[<InlineData(                                     "etthundraett",        101)>]
[<InlineData(                                      "etthundraen",        101)>]
[<InlineData(                                  "etthundraochett",        101)>]
[<InlineData(                               "ett-hundra-och-ett",        101)>]
[<InlineData(                                        "tvåhundra",        200)>]
[<InlineData(                              "tvåhundratrettiosju",        237)>]
[<InlineData(                              "trehundrasjuttiofem",        375)>]
[<InlineData(                                 "fyrahundranittio",        490)>]
[<InlineData(                               "femhundrasextiotre",        563)>]
[<InlineData(                                   "sexhundraarton",        618)>]
[<InlineData(                              "sjuhundrasjuttiosju",        777)>]
[<InlineData(                                    "åttahundrafem",        805)>]
[<InlineData(                                 "åttahundraochsex",        806)>]
[<InlineData(                              "åtta-hundra-och-sju",        807)>]
[<InlineData(                               "niohundrafemtionio",        959)>]
[<InlineData(                                            "tusen",       1000)>]
[<InlineData(                                          "ettusen",       1000)>]
[<InlineData(                                        "ett-tusen",       1000)>]
[<InlineData(                                      "tusenochett",       1001)>]
[<InlineData(                                       "tusenochen",       1001)>]
[<InlineData(                                    "ettusenochtvå",       1002)>]
[<InlineData(                             "ettusenochsextiofyra",       1064)>]
[<InlineData(                                         "tvåtusen",       2000)>]
[<InlineData(                    "åttatusenochsjuhundratjugoett",       8721)>]
[<InlineData(                     "åttatusenochsjuhundratjugoen",       8721)>]
[<InlineData(                   "nio-tusen-ett-hundra-tjugo-tre",       9123)>]
[<InlineData(                                         "tiotusen",      10000)>]
[<InlineData(                             "tiotusenetthundraett",      10101)>]
[<InlineData(                     "tio-tusen-ett-hundra-och-två",      10102)>]
[<InlineData(                 "tjugotretusenfemhundrasextiofyra",      23564)>]
[<InlineData(                                 "åttiotusenochtio",      80010)>]
[<InlineData(                                      "hundratusen",     100000)>]
[<InlineData(                                   "etthundratusen",     100000)>]
[<InlineData(                             "etthundratusenochett",     100001)>]
[<InlineData(           "trehundranittontusentrehundrafyrtionio",     319349)>]
[<InlineData(                                         "enmiljon",    1000000)>]
[<InlineData(                                      "enmiljonett",    1000001)>]
[<InlineData(                                       "enmiljonen",    1000001)>]
[<InlineData(                                   "tvåmiljonertio",    2000010)>]
[<InlineData(                          "sexmiljonertrettiotusen",    6030000)>]
[<InlineData(        "niomiljonertvåhundraettusensexhundraåttio",    9201680)>]
[<InlineData(                                      "tiomiljoner",   10000000)>]
[<InlineData(                                   "tiomiljonernio",   10000009)>]
[<InlineData(                                  "tjugoenmiljoner",   21000000)>]
[<InlineData(    "fyrtiosjumiljonersexhundrasextioettusensextio",   47661060)>]
[<InlineData(                                   "hundramiljoner",  100000000)>]
[<InlineData(                                "etthundramiljoner",  100000000)>]
[<InlineData(                             "tvåhundrafemmiljoner",  205000000)>]
[<InlineData(                      "tre-hundra-och-sju-miljoner",  307000000)>]
[<InlineData(   "fyrahundrasextioenmiljonersextiotusensexhundra",  461060600)>]
[<InlineData(                                        "enmiljard", 1000000000)>]
[<InlineData(                                     "tvåmiljarder", 2000000000)>]
[<InlineData("tvåmiljarderfyrtioniomiljonersexhundrafemtiotusen", 2049650000)>]
[<InlineData(
    "tvåmiljarderetthundrafyrtiosjumiljonerfyrahundraåttiotretusensexhundrafyrtiosju",
    System.Int32.MaxValue)>]
let ``tryParseSwedish returns correct result`` (swedish, expected) =
    let actual = Numeral.tryParseSwedish swedish
    Some expected =! actual

[<UseCulture("sv-SE")>]
[<Theory>]
[<InlineData(         0, "noll")>]
[<InlineData(         1, "ett")>]
[<InlineData(         2, "två")>]
[<InlineData(         3, "tre")>]
[<InlineData(         4, "fyra")>]
[<InlineData(         5, "fem")>]
[<InlineData(         6, "sex")>]
[<InlineData(         7, "sju")>]
[<InlineData(         8, "åtta")>]
[<InlineData(         9, "nio")>]
[<InlineData(        10, "tio")>]
[<InlineData(        11, "elva")>]
[<InlineData(        12, "tolv")>]
[<InlineData(        13, "tretton")>]
[<InlineData(        14, "fjorton")>]
[<InlineData(        15, "femton")>]
[<InlineData(        16, "sexton")>]
[<InlineData(        17, "sjutton")>]
[<InlineData(        18, "arton")>]
[<InlineData(        19, "nitton")>]
[<InlineData(        20, "tjugo")>]
[<InlineData(        21, "tjugo-ett")>]
[<InlineData(        30, "trettio")>]
[<InlineData(        34, "trettio-fyra")>]
[<InlineData(        40, "fyrtio")>]
[<InlineData(        42, "fyrtio-två")>]
[<InlineData(        50, "femtio")>]
[<InlineData(        58, "femtio-åtta")>]
[<InlineData(        60, "sextio")>]
[<InlineData(        65, "sextio-fem")>]
[<InlineData(        70, "sjuttio")>]
[<InlineData(        79, "sjuttio-nio")>]
[<InlineData(        80, "åttio")>]
[<InlineData(        86, "åttio-sex")>]
[<InlineData(        90, "nittio")>]
[<InlineData(        93, "nittio-tre")>]
[<InlineData(       100, "ett-hundra")>]
[<InlineData(       101, "ett-hundra-ett")>]
[<InlineData(       110, "ett-hundra-tio")>]
[<InlineData(       114, "ett-hundra-fjorton")>]
[<InlineData(       135, "ett-hundra-trettio-fem")>]
[<InlineData(       200, "två-hundra")>]
[<InlineData(       282, "två-hundra-åttio-två")>]
[<InlineData(       331, "tre-hundra-trettio-ett")>]
[<InlineData(       407, "fyra-hundra-sju")>]
[<InlineData(       520, "fem-hundra-tjugo")>]
[<InlineData(       666, "sex-hundra-sextio-sex")>]
[<InlineData(       798, "sju-hundra-nittio-åtta")>]
[<InlineData(       857, "åtta-hundra-femtio-sju")>]
[<InlineData(       999, "nio-hundra-nittio-nio")>]
[<InlineData(      1000, "ett-tusen")>]
[<InlineData(      1001, "ett-tusen-ett")>]
[<InlineData(      1010, "ett-tusen-tio")>]
[<InlineData(      1066, "ett-tusen-sextio-sex")>]
[<InlineData(      1337, "ett-tusen-tre-hundra-trettio-sju")>]
[<InlineData(      1984, "ett-tusen-nio-hundra-åttio-fyra")>]
[<InlineData(      2015, "två-tusen-femton")>]
[<InlineData(      3000, "tre-tusen")>]
[<InlineData(      3297, "tre-tusen-två-hundra-nittio-sju")>]
[<InlineData(      4080, "fyra-tusen-åttio")>]
[<InlineData(      5011, "fem-tusen-elva")>]
[<InlineData(      6025, "sex-tusen-tjugo-fem")>]
[<InlineData(      7441, "sju-tusen-fyra-hundra-fyrtio-ett")>]
[<InlineData(      8513, "åtta-tusen-fem-hundra-tretton")>]
[<InlineData(      9000, "nio-tusen")>]
[<InlineData(     10000, "tio-tusen")>]
[<InlineData(     12001, "tolv-tusen-ett")>]
[<InlineData(     23456, "tjugo-tre-tusen-fyra-hundra-femtio-sex")>]
[<InlineData(     32109, "trettio-två-tusen-ett-hundra-nio")>]
[<InlineData(     40404, "fyrtio-tusen-fyra-hundra-fyra")>]
[<InlineData(     56789, "femtio-sex-tusen-sju-hundra-åttio-nio")>]
[<InlineData(     60015, "sextio-tusen-femton")>]
[<InlineData(     71003, "sjuttio-ett-tusen-tre")>]
[<InlineData(     80522, "åttio-tusen-fem-hundra-tjugo-två")>]
[<InlineData(     98765, "nittio-åtta-tusen-sju-hundra-sextio-fem")>]
[<InlineData(    100000, "ett-hundra-tusen")>]
[<InlineData(    100001, "ett-hundra-tusen-ett")>]
[<InlineData(    100010, "ett-hundra-tusen-tio")>]
[<InlineData(    101010, "ett-hundra-ett-tusen-tio")>]
[<InlineData(    200000, "två-hundra-tusen")>]
[<InlineData(    321000, "tre-hundra-tjugo-ett-tusen")>]
[<InlineData(    411416, "fyra-hundra-elva-tusen-fyra-hundra-sexton")>]
[<InlineData(    530121, "fem-hundra-trettio-tusen-ett-hundra-tjugo-ett")>]
[<InlineData(    600000, "sex-hundra-tusen")>]
[<InlineData(    788000, "sju-hundra-åttio-åtta-tusen")>]
[<InlineData(    876540, "åtta-hundra-sjuttio-sex-tusen-fem-hundra-fyrtio")>]
[<InlineData(    908077, "nio-hundra-åtta-tusen-sjuttio-sju")>]
[<InlineData(   1000000, "en-miljon")>]
[<InlineData(   2000002, "två-miljoner-två")>]
[<InlineData(   3040506, "tre-miljoner-fyrtio-tusen-fem-hundra-sex")>]
[<InlineData(   4321000, "fyra-miljoner-tre-hundra-tjugo-ett-tusen")>]
[<InlineData(   5004621, "fem-miljoner-fyra-tusen-sex-hundra-tjugo-ett")>]
[<InlineData(   6982001, "sex-miljoner-nio-hundra-åttio-två-tusen-ett")>]
[<InlineData(   7000000, "sju-miljoner")>]
[<InlineData(   8000220, "åtta-miljoner-två-hundra-tjugo")>]
[<InlineData(   9099000, "nio-miljoner-nittio-nio-tusen")>]
[<InlineData(  10000000, "tio-miljoner")>]
[<InlineData(  24000000, "tjugo-fyra-miljoner")>]
[<InlineData(  39020011, "trettio-nio-miljoner-tjugo-tusen-elva")>]
[<InlineData(  40606100, "fyrtio-miljoner-sex-hundra-sex-tusen-ett-hundra")>]
[<InlineData(  53000000, "femtio-tre-miljoner")>]
[<InlineData(  64000098, "sextio-fyra-miljoner-nittio-åtta")>]
[<InlineData(  70003190, "sjuttio-miljoner-tre-tusen-ett-hundra-nittio")>]
[<InlineData(  80000000, "åttio-miljoner")>]
[<InlineData(  99000099, "nittio-nio-miljoner-nittio-nio")>]
[<InlineData( 100000000, "ett-hundra-miljoner")>]
[<InlineData( 209000000, "två-hundra-nio-miljoner")>]
[<InlineData( 398000000, "tre-hundra-nittio-åtta-miljoner")>]
[<InlineData( 439011000, "fyra-hundra-trettio-nio-miljoner-elva-tusen")>]
[<InlineData( 560400000, "fem-hundra-sextio-miljoner-fyra-hundra-tusen")>]
[<InlineData( 600010900, "sex-hundra-miljoner-tio-tusen-nio-hundra")>]
[<InlineData( 700000000, "sju-hundra-miljoner")>]
[<InlineData( 800116000, "åtta-hundra-miljoner-ett-hundra-sexton-tusen")>]
[<InlineData( 900800007, "nio-hundra-miljoner-åtta-hundra-tusen-sju")>]
[<InlineData(1000000000, "en-miljard")>]
[<InlineData(1001001111, "en-miljard-en-miljon-ett-tusen-ett-hundra-elva")>]
[<InlineData(2121000000, "två-miljarder-ett-hundra-tjugo-en-miljoner")>]
[<InlineData(
    System.Int32.MaxValue,
    "två-miljarder-ett-hundra-fyrtio-sju-miljoner-fyra-hundra-åttio-tre-tusen-sex-hundra-fyrtio-sju")>]
let ``toSwedish returns correct result`` (i, expected) =
    let actual = Numeral.toSwedish i
    expected =! actual