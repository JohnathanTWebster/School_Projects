try (
                // Create output file
                PrintWriter output = new PrintWriter(file);) {
            // Write 100 integers created radomly to file
            for (int i = 0; i < 100; i++) {
                output.print(((int) (Math.random() * 500) + 1));
                output.print(" ");
            }
        }