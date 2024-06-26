package com.jdtp.firtssteeps.app
import android.content.res.Configuration
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.material3.Scaffold
import androidx.compose.runtime.Composable
import androidx.compose.ui.Modifier
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp
import com.jdtp.firtssteeps.composables.AddContact
import com.jdtp.firtssteeps.composables.ContactsList
import com.jdtp.firtssteeps.data.Contact
import com.jdtp.firtssteeps.ui.theme.FirtsSteepsTheme


@Composable
fun MyApp(){
    Column {
        val contacts: List<Contact> = AddContact()
        Spacer(Modifier.height(20.dp))
        ContactsList(contacts = contacts.distinctBy{it.contact})
    }
}

@Preview(
    showSystemUi = true,
    uiMode = Configuration.UI_MODE_NIGHT_YES,
    showBackground = true,
    name="Dark Mode"
)
@Preview(
    showSystemUi = true,
    name= "Light Mode"
)
@Composable
fun GreetingPreview() {
    FirtsSteepsTheme {
        Scaffold(modifier = Modifier.fillMaxSize()) { innerPadding ->
            Column(Modifier.padding(innerPadding)) {
                MyApp()
            }
        }
    }
}