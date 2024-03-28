/**
 * @file Dashboard.java
 * @brief This file contains the Dashboard class, which is responsible for managing the dashboard activity.
 */

package com.example.myapplication;
import android.os.AsyncTask;
import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.AutoCompleteTextView;
import android.widget.Button;
import android.widget.Toast;
import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.sql.DataTruncation;

/**
 * @class Dashboard
 * @brief The Dashboard class represents the dashboard activity of the application.
 */
public class Dashboard extends AppCompatActivity {

    // Arrays to hold options for AutoCompleteTextViews
    private String[] recipeOptions;
    private String[] serviceOptions;
    private String[] sugarOptions;
    private String[] milkOptions;
    private String[] strengthOptions;
    private static final String ESP32_IP = "192.168.1.100"; // Địa chỉ IP của ESP32
    private static final int ESP32_PORT = 80; // Cổng ESP32 đang lắng nghe
    /**
     * @brief Initializes the activity and sets up edge-to-edge display.
     * @param savedInstanceState The saved instance state.
     */
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_dashboard);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        // Initialize arrays from resources
        recipeOptions = getResources().getStringArray(R.array.recipe_options);
        serviceOptions = getResources().getStringArray(R.array.service_options);
        sugarOptions = getResources().getStringArray(R.array.sugar_options);
        milkOptions = getResources().getStringArray(R.array.milk_options);
        strengthOptions = getResources().getStringArray(R.array.strength_options);

        // Set up AutoCompleteTextViews
        setupAutoCompleteTextViews();
        Button printSelectionButton = findViewById(R.id.printSelectionButton);
        printSelectionButton.setOnClickListener(v ->sendMessage(getSelectedDropdown()));
    }

    /**
     * @brief Sets up AutoCompleteTextViews by setting adapters.
     */
    private void setupAutoCompleteTextViews() {
        setAdapterForAutoCompleteTextView(findViewById(R.id.recipe), recipeOptions);
        setAdapterForAutoCompleteTextView(findViewById(R.id.service), serviceOptions);
        setAdapterForAutoCompleteTextView(findViewById(R.id.sugar), sugarOptions);
        setAdapterForAutoCompleteTextView(findViewById(R.id.milk), milkOptions);
        setAdapterForAutoCompleteTextView(findViewById(R.id.strengthOfCoffee), strengthOptions);
    }

    /**
     * @brief Sets adapter for AutoCompleteTextView with given options.
     * @param autoCompleteTextView The AutoCompleteTextView to set adapter for.
     * @param options The options to be displayed in the AutoCompleteTextView.
     */
    private void setAdapterForAutoCompleteTextView(AutoCompleteTextView autoCompleteTextView, String[] options) {
        ArrayAdapter<String> adapter = new ArrayAdapter<>(this, android.R.layout.simple_dropdown_item_1line, options);
        autoCompleteTextView.setAdapter(adapter);
    }
    private String getSelectedDropdown() {
        return ((AutoCompleteTextView) findViewById(R.id.recipe)).getText().toString()+","
        +((AutoCompleteTextView) findViewById(R.id.service)).getText().toString()+","
        +((AutoCompleteTextView) findViewById(R.id.sugar)).getText().toString()+","
        +((AutoCompleteTextView) findViewById(R.id.milk)).getText().toString()+","
        +((AutoCompleteTextView) findViewById(R.id.strengthOfCoffee)).getText().toString();
    }
    private void sendMessage(String message) {
        new SendMessageTask().execute(message);
    }

    private class SendMessageTask extends AsyncTask<String, Void, Boolean> {

        @Override
        protected Boolean doInBackground(String... params) {
            String message = params[0];
            try {
                Socket socket = new Socket(ESP32_IP, ESP32_PORT);
                DataOutputStream outputStream = new DataOutputStream(socket.getOutputStream());
                outputStream.writeUTF(message);
                outputStream.flush();
                outputStream.close();
                socket.close();
                return true;
            } catch (IOException e) {
                e.printStackTrace();
                return false;
            }
        }

        @Override
        protected void onPostExecute(Boolean success) {
            super.onPostExecute(success);
            if (success) {
                Toast.makeText(Dashboard.this, "Message sent successfully", Toast.LENGTH_SHORT).show();
            } else {
                Toast.makeText(Dashboard.this, "Failed to send message", Toast.LENGTH_SHORT).show();
            }
        }
    }
}
