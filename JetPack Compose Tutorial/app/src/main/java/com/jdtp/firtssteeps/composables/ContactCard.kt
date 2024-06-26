package com.jdtp.firtssteeps.composables
import androidx.compose.foundation.Image
import androidx.compose.foundation.border
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.size
import androidx.compose.foundation.layout.width
import androidx.compose.foundation.shape.CircleShape
import androidx.compose.material3.MaterialTheme
import androidx.compose.material3.Surface
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Modifier
import androidx.compose.ui.draw.clip
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.unit.dp
import com.jdtp.firtssteeps.R
import com.jdtp.firtssteeps.data.Contact

@Composable
fun ContactCard(contact: Contact){
    Spacer(Modifier.height(10.dp))
    Row {
        Spacer(modifier = Modifier.width(10.dp))

        Image(
            painter = painterResource(R.drawable.ic_launcher_foreground),
            contentDescription = "photo proof",
            modifier = Modifier
                .clip(CircleShape)
                .size(80.dp)
                .border(1.5.dp, MaterialTheme.colorScheme.primary, CircleShape)
        )
        Spacer(Modifier.height(20.dp))
        Spacer(modifier = Modifier.width(10.dp))
        var isExpanded by remember { mutableStateOf(false) }
        Column  {
            Text(
                text = contact.contact,
                color = MaterialTheme.colorScheme.secondary,
                style = MaterialTheme.typography.titleLarge
            )
            Spacer(modifier = Modifier.height(4.dp))
            Surface(
                modifier = Modifier
                    .fillMaxWidth()
                    .clickable { isExpanded = !isExpanded },
                shape = MaterialTheme.shapes.medium,
                shadowElevation = 1.dp,
            ) {
                Column(modifier = Modifier.padding(5.dp)) {
                    Text(
                        text = contact.description,

                        maxLines = if (isExpanded) Int.MAX_VALUE else 1,
                        style = MaterialTheme.typography.bodyMedium,
                    )
                    Spacer(modifier = Modifier.height(4.dp))
                    Text(
                        text = contact.number.toString(),

                        style = MaterialTheme.typography.bodyMedium,
                    )
                }
            }

        }
    }
}