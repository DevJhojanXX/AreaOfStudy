package com.jdtp.firtssteeps.composables
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.runtime.Composable
import androidx.compose.runtime.remember
import com.jdtp.firtssteeps.data.Contact

@Composable
fun ContactsList(contacts: List<Contact>){

    LazyColumn {
        items(contacts){ contact -> ContactCard(contact = contact)}
    }
}