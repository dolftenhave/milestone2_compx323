import java.io.BufferedReader;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.random;

class csvFile {

	private int col[][];
	Random rand;

	private Arraylist<String[]> data;

	/**
	 * Creates a new csvFile object that contains the data from the speciefied columns
	 * @param path the path of the file 
	 * @param col[] the columns of the file that you want to keep
	 */
	public  csvFile(String path, int col[]){
		createPathTranslator(col[]);		
		readAllData(path);
	}

	/**
	 * Creates a pointer array that translate the requested column into the locally stored column index 
	 */
	private void createPathTranslator(int org[]){
		col = new int[org.length][2];
		for(int i = 0; i < org.length; i++){
			col[i][0] = org[i];
			col[i][1] = i;
		}
	}

	/**
	 * Reads all all the data of the csv file and stores the specified columns in an array
	 */
	private void readAllData(String path){
		try{
			BufferedReader in = new BufferedReader(new FileReader(path));	
			String line;
			String split;
			String save;
			boolean eof = false;
			data = new ArrayList<String[]>()

			while(eof){
				line = in.readLine();
				if(line != null){
					split = line.split(",");	
					save = new String[col.length];
					for(int i = 0; i < col.length; i++){
						save[i] = line[col[i][0]];
					}
					data.add(save);
				}else{
					eof = true;
				}
			}
		}catch(Exception e){
			e.printStackTrace(System.err);
	}

	private static int reverseTranslate(int i){
		return col[
	}

}
