import java.io.BufferedReader;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.Hashtable;
import java.util.Random;

class csvFile {

	private Hashtable<Integer, Integer> col;
	private Random rand;
	private int currentLine;
	private ArrayList<String[]> data;

	/**
	 * Creates a new csvFile object that contains the data from the speciefied columns
	 * @param path the path of the file 
	 * @param col[] the columns of the file that you want to keep
	 */
	public csvFile(String path, int columns[]){
		rand = new Random();
		createPathTranslator(columns);		
		readAllData(path,columns);
	}

	/**
	 * Creates a pointer array that translate the requested column into the locally stored column index 
	 */
	private void createPathTranslator(int org[]){
		col = new Hashtable<Integer, Integer>();
		for(int i = 0; i < org.length; i++){
			col.put(org[i],i);
		}
	}

	/**
	 * Reads all all the data of the csv file and stores the specified columns in an array
	 */
	private void readAllData(String path, int columns[]){
		try{
			BufferedReader in = new BufferedReader(new FileReader(path));	
			String line;
			String split[];
			String save[];
			boolean eof = false;
			int lines = 0;
			data = new ArrayList<String[]>();

			while(!eof){
				line = in.readLine();
				if(line != null){
					split = line.split(",");	
					save = new String[col.size()];
					for(int i = 0; i < col.size(); i++){
						save[i] = split[col.get(columns[i])];
					}
					data.add(save);
					lines++;
				}else{
					eof = true;
				}
			}
			System.out.println("csvFile: read " + lines);
			in.close();
		}catch(Exception e){
			e.printStackTrace(System.err);
			System.exit(1);
		}
	}
	
	/**
	 * Returns a random element from the speciefied row
	 * @param column the column in the csv file the data is in 
	 */
	public String getRandomLine(int column){
		String line[] = data.get(rand.nextInt(data.size()));
		return line[col.get(column)];
	}
}
