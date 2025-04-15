import java.io.BufferedWriter;
import java.io.FileWriter;
import java.util.ArrayList;

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

	private static int fileRefs = 0; // The number of external files refferenced for data.

	private static ArrayList<String> table; // a "buffer" array that holds the table data before it is written;

	public static void main(String args[]) {
		_args = args;
		table = new ArrayList<String>();
		createTable();
	}

	private static void createTable() {
		while (p < _args.length) {
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
					System.exit(1);
					break;
			}
		}

		writeTable();
	}

	/**
	 * Writes a head line to the table file with the size of the table ArrayList and
	 * the number of external refferences made;
	 * Then writes the content of table line for line to the file
	 */
	private static void writeTable() {
		try {
			out = new BufferedWriter(new FileWriter(_args[0] + "_table.txt"));

			String head = table.size() + " " + fileRefs;
			out.write(head, 0, head.length());
			out.newLine();
			out.flush();

			for (int i = 0; i < table.size() - 1; i++) {
				out.write(table.get(i), 0, table.get(i).length());
				out.newLine();
				out.flush();
			}
			out.write(table.get(table.size() - 1), 0, table.get(table.size() - 1).length());
			out.flush();

			out.close();

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
		table.add("0 " + _args[p + 1]);
		p += 2;
	}

	/**
	 * Adds a line to the jump table wich indicates the type int and the length of
	 * the int (0 is incremental)
	 */
	private static void int_() {
		table.add("1 " + _args[p + 1]);
		p += 2;
	}

	/**
	 * Adds a line to the jump table which indicated type date
	 */
	private static void date() {
		table.add("2");
		p++;
	}

	/**
	 * Adds a line to the jump table which indicates type time
	 */
	private static void time() {
		table.add("3");
		p++;
	}

	/**
	 * Adds a line to the jump table which indicates type file, followed by the
	 * column of the data and then the directory of the file and the
	 */
	private static void file() {
		table.add("4 " + _args[p + 1] + " " + _args[p + 2]);
		p += 3;
		fileRefs++;
	}

	/**
	 * Writes a line to the jump table which indicates the type double, followed by
	 * the length of the double and where the seperator should be
	 */
	private static void double_() {
		table.add("5 " + _args[p + 1] + " " + _args[p + 2]);
		p += 3;
	}
}
