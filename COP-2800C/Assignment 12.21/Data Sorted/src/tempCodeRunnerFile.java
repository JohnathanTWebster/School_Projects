if (string1.compareTo(string2) > 0) {
                    System.out.println(
                            "The strings " + string1 + " and " + string2 +
                                    " are out of order");
                    dataSorted = false;
                }
                string1 = string2;
            }