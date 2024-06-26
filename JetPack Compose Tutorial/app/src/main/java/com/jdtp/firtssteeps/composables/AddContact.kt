package com.jdtp.firtssteeps.composables

import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.material3.Button
import androidx.compose.material3.Text
import androidx.compose.material3.TextField
import androidx.compose.runtime.Composable
import androidx.compose.runtime.mutableStateListOf
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.ui.Modifier
import androidx.compose.ui.text.input.TextFieldValue
import androidx.compose.ui.unit.dp
import com.jdtp.firtssteeps.data.Contact

@Composable
fun AddContact(): List<Contact> {
    val (name, setName) = remember { mutableStateOf(TextFieldValue()) }
    val (description, setDescription) = remember { mutableStateOf(TextFieldValue()) }
    val (number, setNumber) = remember { mutableStateOf(TextFieldValue()) }
    val contacts = remember { mutableStateListOf<Contact>() }
    Column {
        contacts.addAll(
            listOf(
                Contact(
                    "Jhojan",
                    "Un joven demaciado hermoso para su eda apesar de su 25 sigue siendo guapo ",
                    325864
                ),
            )
        )
        Spacer(Modifier.height(20.dp))
        TextField(
            value = name,
            onValueChange = setName,
            modifier = Modifier
                .fillMaxWidth()
                .padding(horizontal = 16.dp)
        )
        Spacer(Modifier.height(20.dp))
        TextField(
            value = description,
            onValueChange = setDescription,
            modifier = Modifier
                .fillMaxWidth()
                .padding(horizontal = 16.dp)
        )
        Spacer(Modifier.height(20.dp))
        TextField(
            value = number,
            onValueChange = setNumber,
            modifier = Modifier
                .fillMaxWidth()
                .padding(horizontal = 16.dp)
        )
        Spacer(Modifier.height(20.dp))
        Button(
            onClick = {
                if (name.text.isNotEmpty() && description.text.isNotEmpty() && number.text.isNotEmpty()) {
                    val newContact = Contact(name.text, description.text, number.text.toLong())
                    if (!contacts.any { it.number == newContact.number }) {
                        contacts.add(newContact)
                    }
                    setName(TextFieldValue()) // Clear the text fields after adding the contact
                    setDescription(TextFieldValue())
                    setNumber(TextFieldValue())
                }
            },
            modifier = Modifier
                .padding(vertical = 8.dp)
                .fillMaxWidth()
        ) {
            Text("Add")
        }

    }
    return contacts
}