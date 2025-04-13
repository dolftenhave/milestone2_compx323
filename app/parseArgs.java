import java.io.BufferedWriter;
import java.io.FileWriter;

/**
 * @author Dolf ten Have
 * @date 13/04/2025
 *
 *       Parses a set of input parameters which are then used by the this
 *       program to
 *       Create a table that is used by makeCSV to generate lines of csv data.
 */
public class parseArgs {
	private static String _args[];
	private static int p = 1; // a pointer that keeps track of where in the _args array the program is
	private static BufferedWriter out;

	public static void main(String args[]) {
		_args = args;
		createTable();
	}

	private static void createTable() {

		try {
			out = new BufferedWriter(new FileWriter(_args[0] + "_table.txt"));
			out.flush();
		} catch (Exception e) {
			e.printStackTrace(System.err);
			System.exit(1);
		}

		try {
			while (p < _args.length) {
				// As long as the first argument isn't read, add a new line
				if (p != 1) {
					out.newLine();
				}

				switch (_args[p]) {
					// varchar
					case "-v":
						varchar();
						break;
					// integer
					case "-i":
						int_();
						break;
					// date
					case "-d":
						date();
						break;
					// time
					case "-t":
						time();
						break;
					// file
					case "-f":
						file();
						break;
					// double
					case "-o":
						double_();
						break;
					// Unrecognised argument
					default:
						System.err.println("The input '" + _args[p] + "' was not int the correct format");
						out.flush();
						out.close();
						System.exit(1);
						break;
				}
				out.flush();
			}
			out.close();
		} catch (Exception e) {
			e.printStackTrace(System.err);
			System.exit(1);
		}
	}

	/**
	 * Writes a line to the buffered writer Output
	 */
	private static void write(String s) {
		try {
			out.write(s, 0, s.length());
		} catch (Exception e) {
			e.printStackTrace(System.err);
			System.exit(1);
		}
	}

	/**
	 * Adds a line too the jump table which indicates type varchar and the length of
	 * the varchar
	 */
	private static void varchar() {
		write("0 ");
		write(_args[p + 1]);
		p += 2;
	}

	/**
	 * Adds a line to the jump table wich indicates the type int and the length of
	 * the int (0 is incremental)
	 */
	private static void int_() {
		write("1 ");
		write(_args[p + 1]);
		p += 2;
	}

	/**
	 * Adds a line to the jump table which indicated type date
	 */
	private static void date() {
		write("2");
		p++;
	}

	/**
	 * Adds a line to the jump table which indicates type time
	 */
	private static void time() {
		write("3");
		p++;
	}

	/**
	 * Adds a line to the jump table which indicates type file, followed by the
	 * column of the data and then the directory of the file and the
	 */
	private static void file() {
		write("4 ");
		write(_args[p + 1] + " " + _args[p + 2]);
		p += 3;
	}

	/**
	 * Writes a line to the jump table which indicates the type double, followed by
	 * the length of the double and where the seperator should be
	 */
	private static void double_() {
		write("5 ");
		write(_args[p + 1] + " " + _args[p + 2]);
		p += 3;
	}
}
